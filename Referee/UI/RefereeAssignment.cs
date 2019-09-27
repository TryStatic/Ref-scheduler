using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Referee.Core;
using static Referee.UI.ApplicationEntryPoint;
using Word = Microsoft.Office.Interop.Word;


namespace Referee.UI
{
    public partial class RefereeAssignment : Form
    {
        private static Period _currentPeriod;

        public RefereeAssignment()
        {
            InitializeComponent();
            this.CenterToParent();

            // Set the current period.
            _currentPeriod = new Period();
            _currentPeriod.periodos = period;
            _currentPeriod.diorganwsi = organization;
            _currentPeriod.agwnistiki = int.Parse(Regex.Match(agwnistiki, @"\d+").Value);

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationEntryPoint aep = new ApplicationEntryPoint();
            aep.ShowDialog();
            colorTimer.Stop();
            this.Close();
        }

        private void MatchRegime_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MatchRegime.BeginEdit(true);
            //MatchRegime.Rows[0].Cells[4].Style.BackColor = Color.Red; // CELL BACKGROUND COLOR


        }

        private void MatchRegime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        // Form activated
        private void RefereeAssignment_Activated(object sender, EventArgs e)
        {

        }

        private void RefereeAssignment_Load(object sender, EventArgs e)
        {

            // Decoration on the labels
            SetDecorationText();
            // Load the combobox teams/refs etc.
            LoadDataGridViewComboboxItems();
            // Load the assignment data into the grid
            ReloadAssignmentDataIntoGrid();
            // Check whether or not last agwinistiki data exist
            ValidateLastAgwinstikiData();
            // Start Timer
            colorTimer.Start();

        }

        private void ValidateLastAgwinstikiData()
        {
            switch (_currentPeriod.agwnistiki)
            {
                case 1:
                    return;
                case 2:
                {
                    if (ApplicationData.GetLastPeriod(_currentPeriod) == null)
                        MessageBox.Show(
                            "ΠΡΟΣΟΧΗ: ΔΕΝ ΕΧΕΙ ΠΕΡΑΣΤΕΙ Η ΠΡΟΗΓΟΥΜΕΝΗ ΑΓΩΝΙΣΤΙΚΗ ΓΙΑ ΤΗΝ ΣΥΓΚΕΚΡΙΜΕΝΗ ΔΙΟΡΓΑΝΩΣΗ.");
                    return;
                }
                default:
                {
                    if (ApplicationData.GetLastPeriod(_currentPeriod) == null &&
                        ApplicationData.GetSecondToLastPeriod(_currentPeriod) == null)
                    {
                        MessageBox.Show(
                            "ΠΡΟΣΟΧΗ: ΔΕΝ ΕΧΟΥΝ ΠΕΡΑΣΤΕΙ ΟΙ ΔΥΟ(2) ΠΡΟΗΓΟΥΜΕΝΕΣ ΑΓΩΝΙΣΤΙΚΕΣ ΓΙΑ ΤΗΝ ΣΥΓΚΕΚΡΙΜΕΝΗ ΔΙΟΡΓΑΝΩΣΗ.");
                    }
                    else
                    {
                        if (ApplicationData.GetLastPeriod(_currentPeriod) == null)
                            MessageBox.Show(
                                "ΠΡΟΣΟΧΗ: ΔΕΝ ΕΧΕΙ ΠΕΡΑΣΤΕΙ Η ΠΡΟΗΓΟΥΜΕΝΗ ΑΓΩΝΙΣΤΙΚΗ ΓΙΑ ΤΗΝ ΣΥΓΚΕΚΡΙΜΕΝΗ ΔΙΟΡΓΑΝΩΣΗ.");
                        else if (ApplicationData.GetSecondToLastPeriod(_currentPeriod) == null)
                            MessageBox.Show(
                                "ΠΡΟΣΟΧΗ: ΔΕΝ ΕΧΕΙ ΠΕΡΑΣΤΕΙ Η (ΠΑΡΑ)-ΠΡΟΗΓΟΥΜΕΝΗ ΑΓΩΝΙΣΤΙΚΗ ΓΙΑ ΤΗΝ ΣΥΓΚΕΚΡΙΜΕΝΗ ΔΙΟΡΓΑΝΩΣΗ.");
                    }
                    break;
                }
            }
        }

        private void ReloadAssignmentDataIntoGrid()
        {
            foreach (var i in ApplicationData.Periods)
            {
                if (!i.Equals(_currentPeriod)) continue;
                MatchRegime.Rows.Clear();
                foreach (var ass in i.assignments)
                {
                    DataGridViewRow row = (DataGridViewRow)MatchRegime.Rows[0].Clone();
                    row.Cells[0].Value = ass.home.teamName;
                    row.Cells[1].Value = ass.guest.teamName;
                    row.Cells[2].Value = ass.field.fieldName;
                    row.Cells[3].Value = ass.time;
                    row.Cells[4].Value = ass.referee.name;
                    row.Cells[5].Value = ass.helperA.name;
                    row.Cells[6].Value = ass.helperB.name;
                    row.Cells[7].Value = ass.watchRef.name;
                    MatchRegime.Rows.Add(row);
                }
                break;
            }
            CheckAllAssignmentRecordsForConflicts(false);
        }

        // Save Button Clicked
        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            // TODO: Validate, not null or whitespace for Home, Visit and Field. ??????????

            SaveAssignmentData();
            MessageBox.Show(ApplicationData.SaveData()
                ? "ΤΑ ΔΕΔΟΜΕΝΑ ΑΠΟΘΗΚΕΥΤΗΚΑΝ ΜΕ ΕΠΙΤΥΧΙΑ"
                : "ΥΠΗΡΞΕ ΠΡΟΒΛΗΜΑ ΣΤΗΝ ΑΠΟΘΗΚΕΥΣΗ ΤΩΝ ΔΕΔΟΜΕΝΩΝ");
        }

        private void SaveAssignmentData()
        {
            _currentPeriod.assignments.Clear();
            foreach (DataGridViewRow row in MatchRegime.Rows)
            {
                if (row.IsNewRow) continue;

                Assignment newAss = new Assignment();
                newAss.home = new Team() { teamName = row.Cells["hometeam"].Value.ToString() };
                newAss.guest = new Team() { teamName = row.Cells["guestteam"].Value.ToString() };
                newAss.field = new Field() { fieldName = row.Cells["field"].Value.ToString() };
                newAss.time = row.Cells["time"].Value?.ToString() ?? "";
                newAss.referee = new Core.Referee() { name = row.Cells["referee"].Value?.ToString() ?? "" };
                newAss.helperA = new Core.Referee() { name = row.Cells["refereeHelperA"].Value?.ToString() ?? "" };
                newAss.helperB = new Core.Referee() { name = row.Cells["refereeHelperB"].Value?.ToString() ?? "" };
                newAss.watchRef = new Core.WatchRef() { name = row.Cells["refereeObserver"].Value?.ToString() ?? "" };
                _currentPeriod.assignments.Add(newAss);
            }

            // For each saved period
            foreach (var p in ApplicationData.Periods)
            {
                // If our period exists in the data
                if (p.Equals(_currentPeriod))
                {
                    // update p's asssignments.
                    p.assignments = _currentPeriod.assignments;
                    ReloadAssignmentDataIntoGrid();
                    return;
                }
            }

            // Else just create it and add it to the data.
            ApplicationData.AddPeriod(_currentPeriod);
            ReloadAssignmentDataIntoGrid();
        }


        private void LoadDataGridViewComboboxItems()
        {
            referee.Items.Add("");
            refereeHelperA.Items.Add("");
            refereeHelperB.Items.Add("");
            refereeObserver.Items.Add("");

            foreach (var i in ApplicationData.Teams)
            {
                // TODO: This needs proper fixing.
                switch (_currentPeriod.diorganwsi)
                {
                    case "Α\' Ερασιτεχνική":
                        if (i.teamName.Contains("Α\' Ερ"))
                        {
                            hometeam.Items.Add(i.teamName);
                            guestteam.Items.Add(i.teamName);
                        }
                        break;
                    case "Β\' Ερασιτεχνική":
                        if (i.teamName.Contains("Β\' Ερ"))
                        {
                            hometeam.Items.Add(i.teamName);
                            guestteam.Items.Add(i.teamName);
                        }
                        break;
                    case "Γ\' Ερασιτεχνική":
                        if (i.teamName.Contains("Γ\' Ερ"))
                        {
                            hometeam.Items.Add(i.teamName);
                            guestteam.Items.Add(i.teamName);
                        }
                        break;
                }
            }

            foreach (var i in ApplicationData.Fields)
            {
                field.Items.Add(i.fieldName);
            }

            foreach (var i in ApplicationData.Refs)
            {
                referee.Items.Add(i.name);
                refereeHelperA.Items.Add(i.name);
                refereeHelperB.Items.Add(i.name);

            }

            foreach (var i in ApplicationData.WatchRefs)
            {
                refereeObserver.Items.Add(i.name);
            }
        }

        private void SetDecorationText()
        {
            labelPeriod.Text = period;
            labelOrganization.Text = organization;
            labelAgonistiki.Text = agwnistiki;

        }

        private void MatchRegime_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MatchRegime_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            if (combo == null) return;

            string currentSelectedString = combo.SelectedItem.ToString();
            var currentColumn = MatchRegime.SelectedCells[0].ColumnIndex;
            var currentRow = MatchRegime.SelectedCells[0].RowIndex;

            switch (currentColumn)
            {
                case 0: // home
                    break;
                case 1: // visitor
                    break;
                case 2: // field
                    break;
                case 3: // time
                    break;
                case 4: // Ref
                    ValidateRefereeData(currentSelectedString, currentColumn, currentRow);
                    break;
                case 5:
                    ValidateRefereeData(currentSelectedString, currentColumn, currentRow);
                    break;
                case 6:
                    ValidateRefereeData(currentSelectedString, currentColumn, currentRow);
                    break;
                case 7: // refObs
                    break;

            }

            //MessageBox.Show(currentColumn + "   " + currentRow);
        }

        private bool ValidateRefereeData(string currentSelectedString, int currentColumn,int currentRow, bool showMessages = true)
        {
            if (string.IsNullOrWhiteSpace(currentSelectedString) ||
                string.IsNullOrWhiteSpace(currentSelectedString)) return true;

            // blocks
            var myRef = ApplicationData.Refs.Find(x => x.name == currentSelectedString);
            foreach (var b in myRef.blocks)
            {
                var myHomeTeam = GetDataGridStringValue((int)RegimeColumns.Home, currentRow);
                var myGuestTeam = GetDataGridStringValue((int)RegimeColumns.Guest, currentRow);
                if (b.teamName == myHomeTeam)
                {
                    if(showMessages)
                        MessageBox.Show($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΟΡΙΣΤΕΙ ΣΤΟ ΣΥΓΚΕΚΡΙΜΕΝΟ ΑΓΩΝΑ ΔΙΟΤΙ ΕΧΕΙ ΚΩΛΥΜΑ ΜΕ ΤΗΝ ΟΜΑΔΑ:\n{myHomeTeam}.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Violet;

                    return false;
                }
                else if (b.teamName == myGuestTeam)
                {
                    if (showMessages)
                        MessageBox.Show($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΟΡΙΣΤΕΙ ΣΤΟ ΣΥΓΚΕΚΡΙΜΕΝΟ ΑΓΩΝΑ ΔΙΟΤΙ ΕΧΕΙ ΚΩΛΥΜΑ ΜΕ ΤΗΝ ΟΜΑΔΑ:\n{myGuestTeam}.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Violet;
                    return false;
                }
            }

            // Same row, other Refs
            if (currentColumn == (int) RegimeColumns.Ref)
            {
                if (currentSelectedString.Equals(GetDataGridStringValue((int) RegimeColumns.RefhelpA, currentRow)))
                {
                    // Same name with RefA
                    if (showMessages)
                        MessageBox.Show("Ο ΔΙΑΙΤΗΤΗΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ Α' ΒΟΗΘΟ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
                else if (currentSelectedString.Equals(GetDataGridStringValue((int) RegimeColumns.RefhelpB, currentRow)))
                {
                    if (showMessages)
                        MessageBox.Show("Ο ΔΙΑΙΤΗΤΗΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ Β' ΒΟΗΘΟ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
            }
            else if (currentColumn == (int)RegimeColumns.RefhelpA)
            {
                if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.Ref, currentRow)))
                {
                    // Same name with RefA
                    if (showMessages)
                        MessageBox.Show("Ο Α' ΒΟΗΘΟΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
                else if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.RefhelpB, currentRow)))
                {
                    if (showMessages)
                        MessageBox.Show("Α' ΒΟΗΘΟΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ Β' ΒΟΗΘΟ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
            }
            else if (currentColumn == (int)RegimeColumns.RefhelpB)
            {
                if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.Ref, currentRow)))
                {
                    // Same name with RefA
                    if (showMessages)
                        MessageBox.Show("Ο Β' ΒΟΗΘΟΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
                else if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.RefhelpA, currentRow)))
                {
                    if (showMessages)
                        MessageBox.Show("Β' ΒΟΗΘΟΣ ΔΕΝ ΜΠΟΡΕΙ ΝΑ ΕΙΝΑΙ ΙΔΙΟΣ ΜΕ ΤΟΝ Α' ΒΟΗΘΟ ΔΙΑΙΤΗΤΗ.");
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Yellow;
                    return false;
                }
            }

            // Other rows, all refs
            foreach (DataGridViewRow row in MatchRegime.Rows)
            { // For each other row
                if (row.Index == currentRow) continue;
                if (row.IsNewRow) continue;

                if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.Ref, row.Index)))
                { // Ref same as ref
                    var currHomeTeam = GetDataGridStringValue((int)RegimeColumns.Home, row.Index);
                    var currVisitTeam = GetDataGridStringValue((int)RegimeColumns.Guest, row.Index);
                    if (showMessages)
                        MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΧΕΙ ΗΔΗ ΟΡΙΣΤΕΙ ΩΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΙΔΙΑ ΑΓΩΝΣΤΙΚΗ."));
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Aqua;
                    return false;
                }
                if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.RefhelpA, row.Index)))
                { // Ref same as HelperA
                    var currHomeTeam = GetDataGridStringValue((int)RegimeColumns.Home, row.Index);
                    var currVisitTeam = GetDataGridStringValue((int)RegimeColumns.Guest, row.Index);
                    if (showMessages)
                        MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΧΕΙ ΗΔΗ ΟΡΙΣΤΕΙ ΩΣ Α' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΙΔΙΑ ΑΓΩΝΣΤΙΚΗ."));
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Aqua;
                    return false;
                }
                if (currentSelectedString.Equals(GetDataGridStringValue((int)RegimeColumns.RefhelpB, row.Index)))
                { // Ref same as Helperb
                    var currHomeTeam = GetDataGridStringValue((int)RegimeColumns.Home, row.Index);
                    var currVisitTeam = GetDataGridStringValue((int)RegimeColumns.Guest, row.Index);
                    if (showMessages)
                        MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΧΕΙ ΗΔΗ ΟΡΙΣΤΕΙ ΩΣ Β' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΙΔΙΑ ΑΓΩΝΣΤΙΚΗ."));
                    MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Aqua;
                    return false;
                }
            }

            var currentRowTeamHome = GetDataGridStringValue((int)RegimeColumns.Home, currentRow);
            var currentRowTeamGuest = GetDataGridStringValue((int)RegimeColumns.Guest, currentRow);

            var myPeriod = ApplicationData.GetLastPeriod(_currentPeriod);
            if (myPeriod != null)
            {
                foreach (var ass in myPeriod.assignments)
                {
                    var currHomeTeam = ass.home.teamName;
                    var currVisitTeam = ass.guest.teamName;
                    if (
                        ass.referee.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                        (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                       )
                    {

                        if (GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currVisitTeam ||
                            GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currVisitTeam)
                        {
                            if (showMessages)
                                MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ ΠΡΟΗΓΟΥΜΕΝΗ ({myPeriod.agwnistiki}ή) ΑΓΩΝΙΣΤΙΚΗ."));
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Red;
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.Red;
                            return false;
                        }

                    }
                    else if (
                        ass.helperA.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                        (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                    )
                    {
                        if (GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currVisitTeam ||
                            GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currVisitTeam)
                        {
                            if (showMessages)
                                MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ Α' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ ΠΡΟΗΓΟΥΜΕΝΗ ({myPeriod.agwnistiki}ή) ΑΓΩΝΙΣΤΙΚΗ."));
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Red;
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.Red;
                            return false;
                        }

                    }
                    else if (
                        ass.helperB.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                        (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                    )
                    {
                        if (GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Home, currentRow) == currVisitTeam ||
                            GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currHomeTeam || GetDataGridStringValue((int)RegimeColumns.Guest, currentRow) == currVisitTeam)
                        {
                            if (showMessages)
                                MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ B' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ ΠΡΟΗΓΟΥΜΕΝΗ ({myPeriod.agwnistiki}ή) ΑΓΩΝΙΣΤΙΚΗ."));
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.Red;
                            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.Red;
                            return false;
                        }

                    }
                }
            }

            myPeriod = ApplicationData.GetSecondToLastPeriod(_currentPeriod);
            if (myPeriod != null)
            {
                foreach (var ass in myPeriod.assignments)
                {
                    var currHomeTeam = ass.home.teamName;
                    var currVisitTeam = ass.guest.teamName;
                    if (
                        ass.referee.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                         (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                    )
                    {
                        if (showMessages)
                            MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ (ΠΑΡΑ)ΠΡΟΗΓΟΥΜΕΝΗ {myPeriod.agwnistiki} ΑΓΩΝΙΣΤΙΚΗ."));
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.MediumVioletRed;
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.MediumVioletRed;
                        return false;
                    }
                    else if (
                        ass.helperA.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                         (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                    )
                    {
                        if (showMessages)
                            MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ Α' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ (ΠΑΡΑ)ΠΡΟΗΓΟΥΜΕΝΗ {myPeriod.agwnistiki} ΑΓΩΝΙΣΤΙΚΗ."));
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.MediumVioletRed;
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.MediumVioletRed;
                        return false;
                    }
                    else if (
                        ass.helperB.name == currentSelectedString && // Same Name
                        ((ass.home.teamName == currentRowTeamHome || ass.home.teamName == currentRowTeamGuest) || // That home team either same with our home or guest
                         (ass.guest.teamName == currentRowTeamHome || ass.guest.teamName == currentRowTeamGuest)) // That guest team either same with our home or guest
                    )
                    {
                        if (showMessages)
                            MessageBox.Show(string.Format($"Ο ΔΙΑΙΤΗΤΗΣ [{currentSelectedString}] ΕΙΧΕ ΟΡΙΣΤΕΙ ΩΣ B' ΒΟΗΘΟΣ ΔΙΑΙΤΗΤΗΣ ΣΤΟΝ ΑΓΩΝΑ\n[{currHomeTeam}-{currVisitTeam}]\nΣΤΗΝ ΣΤΗΝ (ΠΑΡΑ)ΠΡΟΗΓΟΥΜΕΝΗ {myPeriod.agwnistiki} ΑΓΩΝΙΣΤΙΚΗ."));
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.MediumVioletRed;
                        MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.MediumVioletRed;
                        return false;
                    }
                }
            }
            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.BackColor = Color.White;
            MatchRegime.Rows[currentRow].Cells[currentColumn].Style.SelectionBackColor = Color.White;
            return true;
        }

        public string GetDataGridStringValue(int column, int row)
        {
            return MatchRegime.Rows[row].Cells[column].Value?.ToString() ?? "";
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {

            Export_Data_To_Word(MatchRegime);

        }

        public void Export_Data_To_Word(DataGridView DGV)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                oDoc.PageSetup.TopMargin = oDoc.Application.InchesToPoints(0.15f);
                oDoc.PageSetup.LeftMargin = oDoc.Application.InchesToPoints(0.35f);
                oDoc.PageSetup.BottomMargin = oDoc.Application.InchesToPoints(0.15f);
                oDoc.PageSetup.RightMargin = oDoc.Application.InchesToPoints(0.35f);

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Arial";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 8;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }


                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Table Grid");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();


                // Find and Replace
                /*Microsoft.Office.Interop.Word.Range range = oDoc.Application.ActiveDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "Α\' Ερ:", ReplaceWith: "", Replace: Word.WdReplace.wdReplaceAll);
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "Β\' Ερ:", ReplaceWith: "", Replace: Word.WdReplace.wdReplaceAll);
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "Γ\' Ερ:", ReplaceWith: "", Replace: Word.WdReplace.wdReplaceAll);

                range.Font.Name = "Arial";
                range.Font.Size = 8;*/

            }
        }

        

        private void MatchRegime_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllAssignmentRecordsForConflicts(true);
        }

        private void CheckAllAssignmentRecordsForConflicts(bool showMessages = false)
        {
            int errors = 0;
            int checks = 0;
            foreach (DataGridViewRow row in MatchRegime.Rows)
            {
                if (row.IsNewRow) continue;

                if (string.IsNullOrEmpty(row.Cells[(int)RegimeColumns.Home].Value?.ToString() ?? "") ||
                    string.IsNullOrEmpty(row.Cells[(int)RegimeColumns.Guest].Value?.ToString() ?? "")
                )
                    continue;

                for (int i = 4; i <= 6; i++)
                {
                    checks++;
                    var curString = row.Cells[i].Value?.ToString() ?? "";
                    if (!ValidateRefereeData(curString, i, row.Index, showMessages)) errors++;
                }
            }

            if(showMessages)
                MessageBox.Show(errors == 0
                ? $"ΟΛΑ ΟΚ\n\nΕΓΙΝΑΝ ({checks}) ΕΛΕΓΧΟΙ ΣΤΟΝ ΣΤΟΝ ΠΙΝΑΚΑ ΑΝΑΘΕΣΕΩΝ ΧΩΡΙΣ ΚΑΜΙΑ ΣΥΓΚΡΟΥΣΗ ΔΕΔΟΜΕΝΩΝ."
                : $"\n\nΕΓΙΝΑΝ ({checks}) ΕΛΕΓΧΟΙ ΣΤΟΝ ΣΤΟΝ ΠΙΝΑΚΑ ΑΝΑΘΕΣΕΩΝ ΚΑΙ ΒΡΕΘΗΚΑΝ ({errors}) ΣΥΓΚΡΟΥΣΕΙΣ.");
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {

        }
    }


    public enum RegimeColumns
    {
        Home = 0,
        Guest = 1,
        Field = 2,
        Ref = 4,
        RefhelpA = 5,
        RefhelpB = 6,
        Refwatch = 7

    }
}
