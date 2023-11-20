namespace MB02.BestimmeMax
{
    partial class BestimmeMaximum
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            TxtValue1=new TextBox();
            TxtValue2=new TextBox();
            label4=new Label();
            LblMax=new Label();
            CmdMax1=new Button();
            TxtValue3=new TextBox();
            label5=new Label();
            CmdMax2=new Button();
            CmdMax3=new Button();
            BtnArray=new Button();
            button1=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(22, 25);
            label1.Margin=new Padding(5, 0, 5, 0);
            label1.Name="label1";
            label1.Size=new Size(343, 40);
            label1.TabIndex=0;
            label1.Text="Bestimme Maximum";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(30, 113);
            label2.Margin=new Padding(5, 0, 5, 0);
            label2.Name="label2";
            label2.Size=new Size(92, 25);
            label2.TabIndex=1;
            label2.Text="Erste Zahl:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(30, 171);
            label3.Margin=new Padding(5, 0, 5, 0);
            label3.Name="label3";
            label3.Size=new Size(105, 25);
            label3.TabIndex=2;
            label3.Text="Zweite Zahl:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location=new Point(170, 108);
            TxtValue1.Margin=new Padding(5, 6, 5, 6);
            TxtValue1.Name="TxtValue1";
            TxtValue1.Size=new Size(211, 31);
            TxtValue1.TabIndex=3;
            // 
            // TxtValue2
            // 
            TxtValue2.Location=new Point(170, 167);
            TxtValue2.Margin=new Padding(5, 6, 5, 6);
            TxtValue2.Name="TxtValue2";
            TxtValue2.Size=new Size(211, 31);
            TxtValue2.TabIndex=4;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(30, 298);
            label4.Margin=new Padding(5, 0, 5, 0);
            label4.Name="label4";
            label4.Size=new Size(95, 25);
            label4.TabIndex=5;
            label4.Text="Maximum:";
            // 
            // LblMax
            // 
            LblMax.AutoSize=true;
            LblMax.Location=new Point(165, 298);
            LblMax.Margin=new Padding(5, 0, 5, 0);
            LblMax.Name="LblMax";
            LblMax.Size=new Size(24, 25);
            LblMax.TabIndex=6;
            LblMax.Text=",,,";
            // 
            // CmdMax1
            // 
            CmdMax1.Location=new Point(30, 346);
            CmdMax1.Margin=new Padding(5, 6, 5, 6);
            CmdMax1.Name="CmdMax1";
            CmdMax1.Size=new Size(353, 44);
            CmdMax1.TabIndex=7;
            CmdMax1.Text="Maximum 1. und 2. Zahl";
            CmdMax1.UseVisualStyleBackColor=true;
            CmdMax1.Click+=CmdMax1_Click;
            // 
            // TxtValue3
            // 
            TxtValue3.Location=new Point(170, 227);
            TxtValue3.Margin=new Padding(5, 6, 5, 6);
            TxtValue3.Name="TxtValue3";
            TxtValue3.Size=new Size(211, 31);
            TxtValue3.TabIndex=9;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(30, 229);
            label5.Margin=new Padding(5, 0, 5, 0);
            label5.Name="label5";
            label5.Size=new Size(98, 25);
            label5.TabIndex=8;
            label5.Text="Dritte Zahl:";
            // 
            // CmdMax2
            // 
            CmdMax2.Location=new Point(30, 402);
            CmdMax2.Margin=new Padding(5, 6, 5, 6);
            CmdMax2.Name="CmdMax2";
            CmdMax2.Size=new Size(353, 44);
            CmdMax2.TabIndex=10;
            CmdMax2.Text="Maximum 2. und 3. Zahl";
            CmdMax2.UseVisualStyleBackColor=true;
            CmdMax2.Click+=CmdMax2_Click;
            // 
            // CmdMax3
            // 
            CmdMax3.Location=new Point(30, 462);
            CmdMax3.Margin=new Padding(5, 6, 5, 6);
            CmdMax3.Name="CmdMax3";
            CmdMax3.Size=new Size(353, 44);
            CmdMax3.TabIndex=11;
            CmdMax3.Text="Maximum 1. und 3. Zahl";
            CmdMax3.UseVisualStyleBackColor=true;
            CmdMax3.Click+=CmdMax3_Click;
            // 
            // BtnArray
            // 
            BtnArray.Location=new Point(419, 346);
            BtnArray.Name="BtnArray";
            BtnArray.Size=new Size(230, 44);
            BtnArray.TabIndex=12;
            BtnArray.Text="Array erstellen";
            BtnArray.UseVisualStyleBackColor=true;
            BtnArray.Click+=BtnArray_Click;
            // 
            // button1
            // 
            button1.Location=new Point(426, 427);
            button1.Name="button1";
            button1.Size=new Size(223, 34);
            button1.TabIndex=13;
            button1.Text="Dictionary erstellen";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // BestimmeMaximum
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(828, 539);
            Controls.Add(button1);
            Controls.Add(BtnArray);
            Controls.Add(CmdMax3);
            Controls.Add(CmdMax2);
            Controls.Add(TxtValue3);
            Controls.Add(label5);
            Controls.Add(CmdMax1);
            Controls.Add(LblMax);
            Controls.Add(label4);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin=new Padding(5, 6, 5, 6);
            Name="BestimmeMaximum";
            Text="Aufgabe_10-1-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private Label label4;
        private Label LblMax;
        private Button CmdMax1;
        private TextBox TxtValue3;
        private Label label5;
        private Button CmdMax2;
        private Button CmdMax3;
        private Button BtnArray;
        private Button button1;
    }
}

