namespace MB01.A8_2
{
    partial class A8_2_1
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
            LblValue1=new Label();
            LblValue2=new Label();
            TxtValue1=new TextBox();
            TxtValue2=new TextBox();
            GrpMath=new GroupBox();
            RadbDiv=new RadioButton();
            RadbMul=new RadioButton();
            RadbSub=new RadioButton();
            RadbAdd=new RadioButton();
            LblResult=new Label();
            TxtResult=new TextBox();
            CmdCalculate=new Button();
            GrpMath.SuspendLayout();
            SuspendLayout();
            // 
            // LblValue1
            // 
            LblValue1.AutoSize=true;
            LblValue1.Location=new Point(22, 31);
            LblValue1.Margin=new Padding(5, 0, 5, 0);
            LblValue1.Name="LblValue1";
            LblValue1.Size=new Size(68, 25);
            LblValue1.TabIndex=0;
            LblValue1.Text="1. Zahl:";
            // 
            // LblValue2
            // 
            LblValue2.AutoSize=true;
            LblValue2.Location=new Point(22, 87);
            LblValue2.Margin=new Padding(5, 0, 5, 0);
            LblValue2.Name="LblValue2";
            LblValue2.Size=new Size(68, 25);
            LblValue2.TabIndex=1;
            LblValue2.Text="2. Zahl:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location=new Point(105, 25);
            TxtValue1.Margin=new Padding(5, 6, 5, 6);
            TxtValue1.Name="TxtValue1";
            TxtValue1.Size=new Size(267, 31);
            TxtValue1.TabIndex=2;
            // 
            // TxtValue2
            // 
            TxtValue2.Location=new Point(105, 75);
            TxtValue2.Margin=new Padding(5, 6, 5, 6);
            TxtValue2.Name="TxtValue2";
            TxtValue2.Size=new Size(267, 31);
            TxtValue2.TabIndex=3;
            TxtValue2.TextChanged+=TxtValue2_TextChanged;
            // 
            // GrpMath
            // 
            GrpMath.Controls.Add(RadbDiv);
            GrpMath.Controls.Add(RadbMul);
            GrpMath.Controls.Add(RadbSub);
            GrpMath.Controls.Add(RadbAdd);
            GrpMath.Location=new Point(27, 169);
            GrpMath.Margin=new Padding(5, 6, 5, 6);
            GrpMath.Name="GrpMath";
            GrpMath.Padding=new Padding(5, 6, 5, 6);
            GrpMath.Size=new Size(348, 129);
            GrpMath.TabIndex=4;
            GrpMath.TabStop=false;
            GrpMath.Text="Mathematische Operationen";
            // 
            // RadbDiv
            // 
            RadbDiv.AutoSize=true;
            RadbDiv.Location=new Point(288, 60);
            RadbDiv.Margin=new Padding(5, 6, 5, 6);
            RadbDiv.Name="RadbDiv";
            RadbDiv.Size=new Size(44, 29);
            RadbDiv.TabIndex=3;
            RadbDiv.TabStop=true;
            RadbDiv.Text="/";
            RadbDiv.UseVisualStyleBackColor=true;
            // 
            // RadbMul
            // 
            RadbMul.AutoSize=true;
            RadbMul.Location=new Point(197, 60);
            RadbMul.Margin=new Padding(5, 6, 5, 6);
            RadbMul.Name="RadbMul";
            RadbMul.Size=new Size(45, 29);
            RadbMul.TabIndex=2;
            RadbMul.TabStop=true;
            RadbMul.Text="*";
            RadbMul.UseVisualStyleBackColor=true;
            // 
            // RadbSub
            // 
            RadbSub.AutoSize=true;
            RadbSub.Location=new Point(107, 60);
            RadbSub.Margin=new Padding(5, 6, 5, 6);
            RadbSub.Name="RadbSub";
            RadbSub.Size=new Size(44, 29);
            RadbSub.TabIndex=1;
            RadbSub.TabStop=true;
            RadbSub.Text="-";
            RadbSub.UseVisualStyleBackColor=true;
            // 
            // RadbAdd
            // 
            RadbAdd.AutoSize=true;
            RadbAdd.Location=new Point(12, 60);
            RadbAdd.Margin=new Padding(5, 6, 5, 6);
            RadbAdd.Name="RadbAdd";
            RadbAdd.Size=new Size(49, 29);
            RadbAdd.TabIndex=0;
            RadbAdd.TabStop=true;
            RadbAdd.Text="+";
            RadbAdd.UseVisualStyleBackColor=true;
            // 
            // LblResult
            // 
            LblResult.AutoSize=true;
            LblResult.Location=new Point(22, 325);
            LblResult.Margin=new Padding(5, 0, 5, 0);
            LblResult.Name="LblResult";
            LblResult.Size=new Size(78, 25);
            LblResult.TabIndex=5;
            LblResult.Text="Resultat:";
            // 
            // TxtResult
            // 
            TxtResult.Location=new Point(115, 319);
            TxtResult.Margin=new Padding(5, 6, 5, 6);
            TxtResult.Name="TxtResult";
            TxtResult.Size=new Size(257, 31);
            TxtResult.TabIndex=6;
            // 
            // CmdCalculate
            // 
            CmdCalculate.Location=new Point(27, 388);
            CmdCalculate.Margin=new Padding(5, 6, 5, 6);
            CmdCalculate.Name="CmdCalculate";
            CmdCalculate.Size=new Size(348, 44);
            CmdCalculate.TabIndex=7;
            CmdCalculate.Text="Berechne";
            CmdCalculate.UseVisualStyleBackColor=true;
            CmdCalculate.Click+=CmdCalculate_Click;
            // 
            // A8_2_1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(395, 508);
            Controls.Add(CmdCalculate);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(GrpMath);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(LblValue2);
            Controls.Add(LblValue1);
            Margin=new Padding(5, 6, 5, 6);
            Name="A8_2_1";
            Text="Aufgabe_A8-2-1";
            GrpMath.ResumeLayout(false);
            GrpMath.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValue1;
        private Label LblValue2;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private GroupBox GrpMath;
        private RadioButton RadbDiv;
        private RadioButton RadbMul;
        private RadioButton RadbSub;
        private RadioButton RadbAdd;
        private Label LblResult;
        private TextBox TxtResult;
        private Button CmdCalculate;
    }
}

