namespace MB06.StaticAufgabe
{
    partial class PersonView
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
            BtnCreatePerson = new Button();
            LblShowCounter = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnCreatePerson
            // 
            BtnCreatePerson.Location = new Point(12, 98);
            BtnCreatePerson.Name = "BtnCreatePerson";
            BtnCreatePerson.Size = new Size(230, 34);
            BtnCreatePerson.TabIndex = 0;
            BtnCreatePerson.Text = "Create Person";
            BtnCreatePerson.UseVisualStyleBackColor = true;
            BtnCreatePerson.Click += BtnCreatePerson_Click;
            // 
            // LblShowCounter
            // 
            LblShowCounter.AutoSize = true;
            LblShowCounter.Location = new Point(211, 189);
            LblShowCounter.Name = "LblShowCounter";
            LblShowCounter.Size = new Size(59, 25);
            LblShowCounter.TabIndex = 1;
            LblShowCounter.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 189);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 2;
            label1.Text = "Anzahl Personen:";
            // 
            // PersonView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LblShowCounter);
            Controls.Add(BtnCreatePerson);
            Name = "PersonView";
            Text = "PersonView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreatePerson;
        private Label LblShowCounter;
        private Label label1;
    }
}