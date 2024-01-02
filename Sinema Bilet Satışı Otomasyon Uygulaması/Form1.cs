namespace Sinema_Bilet_Satışı_Otomasyon_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gboxSaloons_Enter(object sender, EventArgs e)
        {

        }

        int durationMethod() 
        {
            int hours = Convert.ToInt32(comboboxDurationHours.Text);
            int minutes = Convert.ToInt32(comboboxDurationMinutes.Text);
            return  hours * 60 + minutes;
        }

        private void makeAllCheckBoxesInGroupBoxEnabled(GroupBox gbox) 
        {
            foreach(var cbox in gbox.Controls.OfType<CheckBox>())
            {
                cbox.Enabled = true;
                int duration = durationMethod();
                if (duration >= 180)
                {
                    cboxSaloon1_2130.Enabled = false;
                    cboxSaloon2_2130.Enabled = false;
                    cboxSaloon3_2130.Enabled = false;
                    cboxSaloon4_2130.Enabled = false;
                    cboxSaloon5_2130.Enabled = false;
                    cboxSaloon6_2130.Enabled = false;
                }
                if (duration >= 360)
                {
                    cboxSaloon1_1830.Enabled = false;
                    cboxSaloon2_1830.Enabled = false;
                    cboxSaloon3_1830.Enabled = false;
                    cboxSaloon4_1830.Enabled = false;
                    cboxSaloon5_1830.Enabled = false;
                    cboxSaloon6_1830.Enabled = false;
                }
                if (duration >= 540)
                {
                    cboxSaloon1_1530.Enabled = false;
                    cboxSaloon2_1530.Enabled = false;
                    cboxSaloon3_1530.Enabled = false;
                    cboxSaloon4_1530.Enabled = false;
                    cboxSaloon5_1530.Enabled = false;
                    cboxSaloon6_1530.Enabled = false;
                }
            }
        }

        private GroupBox findGroupBox(CheckBox cbox)
        {
            foreach (var gbox in gboxSaloons.Controls.OfType<GroupBox>())
            {
                foreach(var cb in gbox.Controls.OfType<CheckBox>())
                {
                    if(cbox == cb)
                    {
                        return gbox;
                    }
                }
            }
            return null;
        }

        private void comboboxDurationHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var gbox in gboxSaloons.Controls.OfType<GroupBox>())
            {
                foreach (var cbox in gbox.Controls.OfType<CheckBox>())
                {
                    cbox.Checked = false;
                    cbox.Enabled = true;
                }
            }

            int duration = durationMethod();

            if (duration >= 180)
            {
                cboxSaloon1_2130.Enabled = false;
                cboxSaloon2_2130.Enabled = false;
                cboxSaloon3_2130.Enabled = false;
                cboxSaloon4_2130.Enabled = false;
                cboxSaloon5_2130.Enabled = false;
                cboxSaloon6_2130.Enabled = false;
            }
            if (duration >= 360)
            {
                cboxSaloon1_1830.Enabled = false;
                cboxSaloon2_1830.Enabled = false;
                cboxSaloon3_1830.Enabled = false;
                cboxSaloon4_1830.Enabled = false;
                cboxSaloon5_1830.Enabled = false;
                cboxSaloon6_1830.Enabled = false;
            }
            if (duration >= 540)
            {
                cboxSaloon1_1530.Enabled = false;
                cboxSaloon2_1530.Enabled = false;
                cboxSaloon3_1530.Enabled = false;
                cboxSaloon4_1530.Enabled = false;
                cboxSaloon5_1530.Enabled = false;
                cboxSaloon6_1530.Enabled = false;
            }
        }

        private void comboboxDurationMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxDurationHours.Enabled = true;
        }

        private void makeCheckboxesAfterMeDisabledOrEnabled(object sender, EventArgs e)
        {
            int duration = durationMethod();
            GroupBox gbox = findGroupBox((CheckBox)sender);
            List<CheckBox> checkBoxes = gbox.Controls.OfType<CheckBox>().ToList();
            int i = checkBoxes.IndexOf((CheckBox)sender);

            if (checkBoxes[i].Checked)
            {
                foreach (CheckBox cbox in checkBoxes)
                {
                    if (cbox == sender && duration >= 180 && i<5)
                    {
                        checkBoxes[i+1].Enabled = false;
                    }
                    if(cbox == sender && duration >= 360 && i<5)
                    {
                        checkBoxes[i+2].Enabled = false;
                    }
                    if(cbox == sender && duration >= 540  && i<5)
                    {
                        checkBoxes[i+3].Enabled = false;
                    }
                    if (cbox == sender && duration >= 720 && i < 5)
                    {
                        checkBoxes[i+4].Enabled = false;
                    }
                }
                return;
            }
            while (i < 5)
            {
                checkBoxes[i].Enabled = true;
                i++;
            }
            makeAllCheckBoxesInGroupBoxEnabled(gbox);
            return;
        }

        private void connectToTheDataBase()
        {
            string connectionString;
        }

    }
}
