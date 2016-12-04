using System;
namespace ConferentieSysteemWinApp
{
    partial class BewerkenConferentieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BewerkenConferentieForm));
            this.splitContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkConferentieTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.controleUserControl1 = new ConferentieSysteemWinApp.UserControls.ControleUserControl();
            this.label10 = new System.Windows.Forms.Label();
            this.startInschrijvingenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aantalDagenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.beschrijvingRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inscrijvingsLimietdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.naamLimietTextBox = new ConferentieSysteemWinApp.UserControls.LimietTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.expertenItemListView = new ConferentieSysteemWinApp.UserControls.ItemListView();
            this.label7 = new System.Windows.Forms.Label();
            this.domeinenListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.expertisenExpertiseUserControl = new ConferentieSysteemWinApp.UserControls.ExpertiseUserControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.inschrijvingsGeldNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lokaalGroupBox = new System.Windows.Forms.GroupBox();
            this.anulerenButton = new System.Windows.Forms.Button();
            this.lokaalToevoegenButton = new System.Windows.Forms.Button();
            this.nieuwLokaalTextBox = new System.Windows.Forms.TextBox();
            this.agendaMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keynoteCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toegevoegdeSessiesListBox = new System.Windows.Forms.ListBox();
            this.agendaExpertiseDomeinComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agendaExpertenComboBox = new System.Windows.Forms.ComboBox();
            this.startUurMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.anderLokaalButton = new System.Windows.Forms.Button();
            this.eindUurMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lokaalComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.verwijderPictureBox = new System.Windows.Forms.PictureBox();
            this.sessieUserControl1 = new ConferentieSysteemWinApp.UserControls.SessieUserControl();
            this.agendaPanel = new System.Windows.Forms.Panel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opslaanButton = new System.Windows.Forms.Button();
            this.overzichtButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContextMenuStrip1.SuspendLayout();
            this.bewerkConferentieTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aantalDagenNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingsGeldNumericUpDown)).BeginInit();
            this.lokaalGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verwijderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContextMenuStrip1
            // 
            this.splitContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
            this.splitContextMenuStrip1.Name = "contextMenuStrip1";
            this.splitContextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.Bewerken;
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bewerkenToolStripMenuItem.Text = "Bewerken";
            this.bewerkenToolStripMenuItem.Click += new System.EventHandler(this.ExpertBewerken);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verwijderen;
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.ExpertVerwijderen);
            // 
            // bewerkConferentieTabControl
            // 
            this.bewerkConferentieTabControl.Controls.Add(this.tabPage1);
            this.bewerkConferentieTabControl.Controls.Add(this.tabPage2);
            this.bewerkConferentieTabControl.Controls.Add(this.tabPage3);
            this.bewerkConferentieTabControl.Controls.Add(this.tabPage4);
            this.bewerkConferentieTabControl.Controls.Add(this.tabPage5);
            this.bewerkConferentieTabControl.Location = new System.Drawing.Point(12, 12);
            this.bewerkConferentieTabControl.Name = "bewerkConferentieTabControl";
            this.bewerkConferentieTabControl.SelectedIndex = 0;
            this.bewerkConferentieTabControl.Size = new System.Drawing.Size(623, 480);
            this.bewerkConferentieTabControl.TabIndex = 14;
            this.bewerkConferentieTabControl.SelectedIndexChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.controleUserControl1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.startInschrijvingenDateTimePicker);
            this.tabPage1.Controls.Add(this.aantalDagenNumericUpDown);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.beschrijvingRichTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.inscrijvingsLimietdateTimePicker);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.naamLimietTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algemeen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // controleUserControl1
            // 
            this.controleUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.controleUserControl1.Bericht = "De datums zijn niet correct.";
            this.controleUserControl1.Check = false;
            this.controleUserControl1.Location = new System.Drawing.Point(378, 44);
            this.controleUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.controleUserControl1.Name = "controleUserControl1";
            this.controleUserControl1.Size = new System.Drawing.Size(230, 52);
            this.controleUserControl1.TabIndex = 11;
            this.controleUserControl1.Click += new System.EventHandler(this.controleUserControl1_Click);
            this.controleUserControl1.CheckVeranderd += new System.EventHandler(this.controleUserControl1_CheckVeranderd);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Start inschrijvingen:";
            // 
            // startInschrijvingenDateTimePicker
            // 
            this.startInschrijvingenDateTimePicker.Location = new System.Drawing.Point(140, 44);
            this.startInschrijvingenDateTimePicker.Name = "startInschrijvingenDateTimePicker";
            this.startInschrijvingenDateTimePicker.Size = new System.Drawing.Size(229, 23);
            this.startInschrijvingenDateTimePicker.TabIndex = 9;
            this.startInschrijvingenDateTimePicker.ValueChanged += new System.EventHandler(this.AanpassenLimiet);
            // 
            // aantalDagenNumericUpDown
            // 
            this.aantalDagenNumericUpDown.Location = new System.Drawing.Point(142, 250);
            this.aantalDagenNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.aantalDagenNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalDagenNumericUpDown.Name = "aantalDagenNumericUpDown";
            this.aantalDagenNumericUpDown.Size = new System.Drawing.Size(72, 23);
            this.aantalDagenNumericUpDown.TabIndex = 8;
            this.aantalDagenNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalDagenNumericUpDown.ValueChanged += new System.EventHandler(this.AantalDagenNumericUpDownValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aantal dagen:";
            // 
            // beschrijvingRichTextBox
            // 
            this.beschrijvingRichTextBox.Location = new System.Drawing.Point(141, 109);
            this.beschrijvingRichTextBox.Name = "beschrijvingRichTextBox";
            this.beschrijvingRichTextBox.Size = new System.Drawing.Size(228, 135);
            this.beschrijvingRichTextBox.TabIndex = 6;
            this.beschrijvingRichTextBox.Text = "";
            this.beschrijvingRichTextBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beschrijvning*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inschrijvings limiet:";
            // 
            // inscrijvingsLimietdateTimePicker
            // 
            this.inscrijvingsLimietdateTimePicker.Location = new System.Drawing.Point(140, 73);
            this.inscrijvingsLimietdateTimePicker.Name = "inscrijvingsLimietdateTimePicker";
            this.inscrijvingsLimietdateTimePicker.Size = new System.Drawing.Size(229, 23);
            this.inscrijvingsLimietdateTimePicker.TabIndex = 2;
            this.inscrijvingsLimietdateTimePicker.ValueChanged += new System.EventHandler(this.ControleerDatums);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam:";
            // 
            // naamLimietTextBox
            // 
            this.naamLimietTextBox.Location = new System.Drawing.Point(141, 15);
            this.naamLimietTextBox.MaxLength = 50;
            this.naamLimietTextBox.Name = "naamLimietTextBox";
            this.naamLimietTextBox.Size = new System.Drawing.Size(229, 23);
            this.naamLimietTextBox.TabIndex = 0;
            this.naamLimietTextBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.expertenItemListView);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.domeinenListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Experten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // expertenItemListView
            // 
            this.expertenItemListView.CheckBoxes = true;
            this.expertenItemListView.FullRowSelect = true;
            this.expertenItemListView.Location = new System.Drawing.Point(6, 12);
            this.expertenItemListView.MultiSelect = false;
            this.expertenItemListView.Name = "expertenItemListView";
            this.expertenItemListView.Size = new System.Drawing.Size(418, 328);
            this.expertenItemListView.TabIndex = 16;
            this.expertenItemListView.UseCompatibleStateImageBehavior = false;
            this.expertenItemListView.View = System.Windows.Forms.View.Details;
            this.expertenItemListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.expertenDetailListView_ItemChecked);
            this.expertenItemListView.SelectedIndexChanged += new System.EventHandler(this.expertenDetailListView_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Domeinen";
            // 
            // domeinenListBox
            // 
            this.domeinenListBox.FormattingEnabled = true;
            this.domeinenListBox.ItemHeight = 16;
            this.domeinenListBox.Location = new System.Drawing.Point(430, 35);
            this.domeinenListBox.Name = "domeinenListBox";
            this.domeinenListBox.Size = new System.Drawing.Size(179, 132);
            this.domeinenListBox.Sorted = true;
            this.domeinenListBox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.expertisenExpertiseUserControl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(615, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Expertise\'s";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // expertisenExpertiseUserControl
            // 
            this.expertisenExpertiseUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expertisenExpertiseUserControl.Location = new System.Drawing.Point(12, 21);
            this.expertisenExpertiseUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.expertisenExpertiseUserControl.Name = "expertisenExpertiseUserControl";
            this.expertisenExpertiseUserControl.Size = new System.Drawing.Size(588, 216);
            this.expertisenExpertiseUserControl.TabIndex = 0;
            this.expertisenExpertiseUserControl.ExpertiseToegevoegdVerwijderd += new System.Action(this.expertiseUserControl1_ExpertiseToegevoegdVerwijderd);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.inschrijvingsGeldNumericUpDown);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.lokaalGroupBox);
            this.tabPage4.Controls.Add(this.agendaMonthCalendar);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(615, 454);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agenda";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // inschrijvingsGeldNumericUpDown
            // 
            this.inschrijvingsGeldNumericUpDown.DecimalPlaces = 2;
            this.inschrijvingsGeldNumericUpDown.Location = new System.Drawing.Point(105, 187);
            this.inschrijvingsGeldNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inschrijvingsGeldNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inschrijvingsGeldNumericUpDown.Name = "inschrijvingsGeldNumericUpDown";
            this.inschrijvingsGeldNumericUpDown.Size = new System.Drawing.Size(78, 23);
            this.inschrijvingsGeldNumericUpDown.TabIndex = 16;
            this.inschrijvingsGeldNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inschrijvings-\r\ngeld dag:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lokaalGroupBox
            // 
            this.lokaalGroupBox.Controls.Add(this.anulerenButton);
            this.lokaalGroupBox.Controls.Add(this.lokaalToevoegenButton);
            this.lokaalGroupBox.Controls.Add(this.nieuwLokaalTextBox);
            this.lokaalGroupBox.Location = new System.Drawing.Point(12, 230);
            this.lokaalGroupBox.Name = "lokaalGroupBox";
            this.lokaalGroupBox.Size = new System.Drawing.Size(171, 113);
            this.lokaalGroupBox.TabIndex = 12;
            this.lokaalGroupBox.TabStop = false;
            this.lokaalGroupBox.Text = "Nieuw lokaal";
            this.lokaalGroupBox.Visible = false;
            // 
            // anulerenButton
            // 
            this.anulerenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Anuleren16;
            this.anulerenButton.Location = new System.Drawing.Point(31, 80);
            this.anulerenButton.Name = "anulerenButton";
            this.anulerenButton.Size = new System.Drawing.Size(115, 26);
            this.anulerenButton.TabIndex = 11;
            this.anulerenButton.Text = "Anuleren";
            this.anulerenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anulerenButton.UseVisualStyleBackColor = true;
            this.anulerenButton.Click += new System.EventHandler(this.anulerenButton_Click);
            // 
            // lokaalToevoegenButton
            // 
            this.lokaalToevoegenButton.Enabled = false;
            this.lokaalToevoegenButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.lokaalToevoegenButton.Location = new System.Drawing.Point(31, 51);
            this.lokaalToevoegenButton.Name = "lokaalToevoegenButton";
            this.lokaalToevoegenButton.Size = new System.Drawing.Size(115, 26);
            this.lokaalToevoegenButton.TabIndex = 9;
            this.lokaalToevoegenButton.Text = "Toevoegen";
            this.lokaalToevoegenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lokaalToevoegenButton.UseVisualStyleBackColor = true;
            this.lokaalToevoegenButton.Click += new System.EventHandler(this.lokaalToevoegenButton_Click);
            // 
            // nieuwLokaalTextBox
            // 
            this.nieuwLokaalTextBox.Location = new System.Drawing.Point(31, 22);
            this.nieuwLokaalTextBox.Name = "nieuwLokaalTextBox";
            this.nieuwLokaalTextBox.Size = new System.Drawing.Size(115, 23);
            this.nieuwLokaalTextBox.TabIndex = 10;
            this.nieuwLokaalTextBox.TextChanged += new System.EventHandler(this.nieuwLokaalTextBox_TextChanged);
            // 
            // agendaMonthCalendar
            // 
            this.agendaMonthCalendar.Location = new System.Drawing.Point(12, 9);
            this.agendaMonthCalendar.MaxSelectionCount = 1;
            this.agendaMonthCalendar.Name = "agendaMonthCalendar";
            this.agendaMonthCalendar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.keynoteCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.toegevoegdeSessiesListBox);
            this.groupBox1.Controls.Add(this.agendaExpertiseDomeinComboBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.agendaExpertenComboBox);
            this.groupBox1.Controls.Add(this.startUurMaskedTextBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.anderLokaalButton);
            this.groupBox1.Controls.Add(this.eindUurMaskedTextBox);
            this.groupBox1.Controls.Add(this.lokaalComboBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(195, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 321);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sessie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Keynote:";
            // 
            // keynoteCheckBox
            // 
            this.keynoteCheckBox.AutoSize = true;
            this.keynoteCheckBox.Location = new System.Drawing.Point(91, 245);
            this.keynoteCheckBox.Name = "keynoteCheckBox";
            this.keynoteCheckBox.Size = new System.Drawing.Size(15, 14);
            this.keynoteCheckBox.TabIndex = 18;
            this.keynoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 51);
            this.label8.TabIndex = 17;
            this.label8.Text = "Reeds\r\ntoegevoegde\r\nsessies:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toegevoegdeSessiesListBox
            // 
            this.toegevoegdeSessiesListBox.FormattingEnabled = true;
            this.toegevoegdeSessiesListBox.IntegralHeight = false;
            this.toegevoegdeSessiesListBox.ItemHeight = 16;
            this.toegevoegdeSessiesListBox.Location = new System.Drawing.Point(105, 26);
            this.toegevoegdeSessiesListBox.Name = "toegevoegdeSessiesListBox";
            this.toegevoegdeSessiesListBox.Size = new System.Drawing.Size(280, 51);
            this.toegevoegdeSessiesListBox.TabIndex = 16;
            // 
            // agendaExpertiseDomeinComboBox
            // 
            this.agendaExpertiseDomeinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agendaExpertiseDomeinComboBox.FormattingEnabled = true;
            this.agendaExpertiseDomeinComboBox.Location = new System.Drawing.Point(91, 92);
            this.agendaExpertiseDomeinComboBox.Name = "agendaExpertiseDomeinComboBox";
            this.agendaExpertiseDomeinComboBox.Size = new System.Drawing.Size(222, 24);
            this.agendaExpertiseDomeinComboBox.TabIndex = 15;
            this.agendaExpertiseDomeinComboBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Experten:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Domeinen:";
            // 
            // agendaExpertenComboBox
            // 
            this.agendaExpertenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agendaExpertenComboBox.FormattingEnabled = true;
            this.agendaExpertenComboBox.Location = new System.Drawing.Point(91, 122);
            this.agendaExpertenComboBox.Name = "agendaExpertenComboBox";
            this.agendaExpertenComboBox.Size = new System.Drawing.Size(222, 24);
            this.agendaExpertenComboBox.TabIndex = 4;
            this.agendaExpertenComboBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // startUurMaskedTextBox2
            // 
            this.startUurMaskedTextBox2.Location = new System.Drawing.Point(91, 153);
            this.startUurMaskedTextBox2.Mask = "00:00";
            this.startUurMaskedTextBox2.Name = "startUurMaskedTextBox2";
            this.startUurMaskedTextBox2.PromptChar = '-';
            this.startUurMaskedTextBox2.Size = new System.Drawing.Size(96, 23);
            this.startUurMaskedTextBox2.TabIndex = 5;
            this.startUurMaskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.startUurMaskedTextBox2.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Start uur:";
            // 
            // anderLokaalButton
            // 
            this.anderLokaalButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Toevoegen16;
            this.anderLokaalButton.Location = new System.Drawing.Point(193, 212);
            this.anderLokaalButton.Name = "anderLokaalButton";
            this.anderLokaalButton.Size = new System.Drawing.Size(120, 24);
            this.anderLokaalButton.TabIndex = 11;
            this.anderLokaalButton.Text = "Ander lokaal";
            this.anderLokaalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.anderLokaalButton.UseVisualStyleBackColor = true;
            this.anderLokaalButton.Click += new System.EventHandler(this.anderLokaalButton_Click);
            // 
            // eindUurMaskedTextBox
            // 
            this.eindUurMaskedTextBox.Location = new System.Drawing.Point(91, 183);
            this.eindUurMaskedTextBox.Mask = "00:00";
            this.eindUurMaskedTextBox.Name = "eindUurMaskedTextBox";
            this.eindUurMaskedTextBox.PromptChar = '-';
            this.eindUurMaskedTextBox.Size = new System.Drawing.Size(96, 23);
            this.eindUurMaskedTextBox.TabIndex = 7;
            this.eindUurMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.eindUurMaskedTextBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // lokaalComboBox
            // 
            this.lokaalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lokaalComboBox.FormattingEnabled = true;
            this.lokaalComboBox.Location = new System.Drawing.Point(91, 212);
            this.lokaalComboBox.Name = "lokaalComboBox";
            this.lokaalComboBox.Size = new System.Drawing.Size(96, 24);
            this.lokaalComboBox.TabIndex = 10;
            this.lokaalComboBox.TextChanged += new System.EventHandler(this.naamLimietTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Eind uur:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Lokaal:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.verwijderPictureBox);
            this.tabPage5.Controls.Add(this.sessieUserControl1);
            this.tabPage5.Controls.Add(this.agendaPanel);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(615, 451);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // verwijderPictureBox
            // 
            this.verwijderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verwijderPictureBox.Image = global::ConferentieSysteemWinApp.Properties.Resources.Verwijderen;
            this.verwijderPictureBox.Location = new System.Drawing.Point(448, 335);
            this.verwijderPictureBox.Name = "verwijderPictureBox";
            this.verwijderPictureBox.Size = new System.Drawing.Size(160, 110);
            this.verwijderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verwijderPictureBox.TabIndex = 2;
            this.verwijderPictureBox.TabStop = false;
            // 
            // sessieUserControl1
            // 
            this.sessieUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessieUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessieUserControl1.Location = new System.Drawing.Point(448, 7);
            this.sessieUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.sessieUserControl1.Name = "sessieUserControl1";
            this.sessieUserControl1.Size = new System.Drawing.Size(160, 110);
            this.sessieUserControl1.TabIndex = 1;
            // 
            // agendaPanel
            // 
            this.agendaPanel.AutoScroll = true;
            this.agendaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.agendaPanel.Location = new System.Drawing.Point(3, 3);
            this.agendaPanel.Name = "agendaPanel";
            this.agendaPanel.Size = new System.Drawing.Size(438, 445);
            this.agendaPanel.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Voornaam";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Achternaam";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bedrijf";
            this.columnHeader3.Width = 150;
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.Opslaan16;
            this.opslaanButton.Location = new System.Drawing.Point(375, 498);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(125, 25);
            this.opslaanButton.TabIndex = 16;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // overzichtButton
            // 
            this.overzichtButton.Image = global::ConferentieSysteemWinApp.Properties.Resources.vorig;
            this.overzichtButton.Location = new System.Drawing.Point(506, 498);
            this.overzichtButton.Name = "overzichtButton";
            this.overzichtButton.Size = new System.Drawing.Size(125, 25);
            this.overzichtButton.TabIndex = 15;
            this.overzichtButton.Text = "Overzicht";
            this.overzichtButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.overzichtButton.UseVisualStyleBackColor = true;
            this.overzichtButton.Click += new System.EventHandler(this.TerugNaarOverzicht);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConferentieSysteemWinApp.Properties.Resources.Informatie;
            this.pictureBox1.Location = new System.Drawing.Point(376, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BewerkenConferentieForm
            // 
            this.ClientSize = new System.Drawing.Size(648, 536);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.overzichtButton);
            this.Controls.Add(this.bewerkConferentieTabControl);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BewerkenConferentieForm";
            this.Text = "Bewerken conferentie";
            this.Load += new System.EventHandler(this.BewerkenConferentieForm_Load);
            this.splitContextMenuStrip1.ResumeLayout(false);
            this.bewerkConferentieTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aantalDagenNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inschrijvingsGeldNumericUpDown)).EndInit();
            this.lokaalGroupBox.ResumeLayout(false);
            this.lokaalGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verwijderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip splitContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl bewerkConferentieTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown aantalDagenNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox beschrijvingRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inscrijvingsLimietdateTimePicker;
        private System.Windows.Forms.Label label2;
        private ConferentieSysteemWinApp.UserControls.LimietTextBox naamLimietTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox domeinenListBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox lokaalGroupBox;
        private System.Windows.Forms.Button lokaalToevoegenButton;
        private System.Windows.Forms.TextBox nieuwLokaalTextBox;
        private System.Windows.Forms.Button anderLokaalButton;
        private System.Windows.Forms.ComboBox lokaalComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox eindUurMaskedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox startUurMaskedTextBox2;
        private System.Windows.Forms.ComboBox agendaExpertenComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MonthCalendar agendaMonthCalendar;
        private UserControls.ExpertiseUserControl expertisenExpertiseUserControl;
        private System.Windows.Forms.NumericUpDown inschrijvingsGeldNumericUpDown;
        private System.Windows.Forms.ComboBox agendaExpertiseDomeinComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button anulerenButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox keynoteCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox toegevoegdeSessiesListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker startInschrijvingenDateTimePicker;
        private UserControls.ItemListView expertenItemListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private UserControls.ControleUserControl controleUserControl1;
        private System.Windows.Forms.Button overzichtButton;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.TabPage tabPage5;
        private UserControls.SessieUserControl sessieUserControl1;
        private System.Windows.Forms.PictureBox verwijderPictureBox;
        private System.Windows.Forms.Panel agendaPanel;

    }
}
