namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultBox = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btt1 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.btt3 = new System.Windows.Forms.Button();
            this.btt6 = new System.Windows.Forms.Button();
            this.btt5 = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.btt9 = new System.Windows.Forms.Button();
            this.btt8 = new System.Windows.Forms.Button();
            this.btt7 = new System.Windows.Forms.Button();
            this.btt0 = new System.Windows.Forms.Button();
            this.bttDot = new System.Windows.Forms.Button();
            this.bttMultiply = new System.Windows.Forms.Button();
            this.bttSubstract = new System.Windows.Forms.Button();
            this.bttAddition = new System.Windows.Forms.Button();
            this.bttResult = new System.Windows.Forms.Button();
            this.bttModule = new System.Windows.Forms.Button();
            this.bttDiv = new System.Windows.Forms.Button();
            this.bttReset = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(33, 45);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(222, 31);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(35, 21);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 13);
            this.lblHistorial.TabIndex = 1;
            // 
            // btt1
            // 
            this.btt1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt1.Location = new System.Drawing.Point(34, 247);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(53, 47);
            this.btt1.TabIndex = 2;
            this.btt1.Text = "1";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // btt2
            // 
            this.btt2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt2.Location = new System.Drawing.Point(89, 247);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(53, 47);
            this.btt2.TabIndex = 3;
            this.btt2.Text = "2";
            this.btt2.UseVisualStyleBackColor = true;
            this.btt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btt3
            // 
            this.btt3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt3.Location = new System.Drawing.Point(145, 247);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(53, 47);
            this.btt3.TabIndex = 4;
            this.btt3.Text = "3";
            this.btt3.UseVisualStyleBackColor = true;
            this.btt3.Click += new System.EventHandler(this.btt3_Click);
            // 
            // btt6
            // 
            this.btt6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt6.Location = new System.Drawing.Point(145, 198);
            this.btt6.Name = "btt6";
            this.btt6.Size = new System.Drawing.Size(53, 47);
            this.btt6.TabIndex = 7;
            this.btt6.Text = "6";
            this.btt6.UseVisualStyleBackColor = true;
            this.btt6.Click += new System.EventHandler(this.btt6_Click);
            // 
            // btt5
            // 
            this.btt5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt5.Location = new System.Drawing.Point(89, 198);
            this.btt5.Name = "btt5";
            this.btt5.Size = new System.Drawing.Size(53, 47);
            this.btt5.TabIndex = 6;
            this.btt5.Text = "5";
            this.btt5.UseVisualStyleBackColor = true;
            this.btt5.Click += new System.EventHandler(this.btt5_Click);
            // 
            // btt4
            // 
            this.btt4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt4.Location = new System.Drawing.Point(34, 198);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(53, 47);
            this.btt4.TabIndex = 5;
            this.btt4.Text = "4";
            this.btt4.UseVisualStyleBackColor = true;
            this.btt4.Click += new System.EventHandler(this.btt4_Click);
            // 
            // btt9
            // 
            this.btt9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt9.Location = new System.Drawing.Point(145, 149);
            this.btt9.Name = "btt9";
            this.btt9.Size = new System.Drawing.Size(53, 47);
            this.btt9.TabIndex = 10;
            this.btt9.Text = "9";
            this.btt9.UseVisualStyleBackColor = true;
            this.btt9.Click += new System.EventHandler(this.btt9_Click);
            // 
            // btt8
            // 
            this.btt8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt8.Location = new System.Drawing.Point(89, 149);
            this.btt8.Name = "btt8";
            this.btt8.Size = new System.Drawing.Size(53, 47);
            this.btt8.TabIndex = 9;
            this.btt8.Text = "8";
            this.btt8.UseVisualStyleBackColor = true;
            this.btt8.Click += new System.EventHandler(this.btt8_Click);
            // 
            // btt7
            // 
            this.btt7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt7.Location = new System.Drawing.Point(34, 149);
            this.btt7.Name = "btt7";
            this.btt7.Size = new System.Drawing.Size(53, 47);
            this.btt7.TabIndex = 8;
            this.btt7.Text = "7";
            this.btt7.UseVisualStyleBackColor = true;
            this.btt7.Click += new System.EventHandler(this.btt7_Click);
            // 
            // btt0
            // 
            this.btt0.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt0.Location = new System.Drawing.Point(34, 298);
            this.btt0.Name = "btt0";
            this.btt0.Size = new System.Drawing.Size(108, 47);
            this.btt0.TabIndex = 11;
            this.btt0.Text = "0";
            this.btt0.UseVisualStyleBackColor = true;
            this.btt0.Click += new System.EventHandler(this.btt0_Click);
            // 
            // bttDot
            // 
            this.bttDot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDot.Location = new System.Drawing.Point(145, 298);
            this.bttDot.Name = "bttDot";
            this.bttDot.Size = new System.Drawing.Size(53, 47);
            this.bttDot.TabIndex = 12;
            this.bttDot.Text = ".";
            this.bttDot.UseVisualStyleBackColor = true;
            this.bttDot.Click += new System.EventHandler(this.bttDot_Click);
            // 
            // bttMultiply
            // 
            this.bttMultiply.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMultiply.Location = new System.Drawing.Point(202, 149);
            this.bttMultiply.Name = "bttMultiply";
            this.bttMultiply.Size = new System.Drawing.Size(53, 47);
            this.bttMultiply.TabIndex = 13;
            this.bttMultiply.Text = "x";
            this.bttMultiply.UseVisualStyleBackColor = true;
            this.bttMultiply.Click += new System.EventHandler(this.bttMultiply_Click);
            // 
            // bttSubstract
            // 
            this.bttSubstract.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSubstract.Location = new System.Drawing.Point(202, 198);
            this.bttSubstract.Name = "bttSubstract";
            this.bttSubstract.Size = new System.Drawing.Size(53, 47);
            this.bttSubstract.TabIndex = 14;
            this.bttSubstract.Text = "-";
            this.bttSubstract.UseVisualStyleBackColor = true;
            this.bttSubstract.Click += new System.EventHandler(this.bttSubstract_Click);
            // 
            // bttAddition
            // 
            this.bttAddition.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddition.Location = new System.Drawing.Point(202, 247);
            this.bttAddition.Name = "bttAddition";
            this.bttAddition.Size = new System.Drawing.Size(53, 47);
            this.bttAddition.TabIndex = 15;
            this.bttAddition.Text = "+";
            this.bttAddition.UseVisualStyleBackColor = true;
            this.bttAddition.Click += new System.EventHandler(this.bttAddition_Click);
            // 
            // bttResult
            // 
            this.bttResult.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttResult.Location = new System.Drawing.Point(202, 298);
            this.bttResult.Name = "bttResult";
            this.bttResult.Size = new System.Drawing.Size(53, 47);
            this.bttResult.TabIndex = 16;
            this.bttResult.Text = "=";
            this.bttResult.UseVisualStyleBackColor = true;
            this.bttResult.Click += new System.EventHandler(this.bttResult_Click);
            // 
            // bttModule
            // 
            this.bttModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttModule.Location = new System.Drawing.Point(34, 99);
            this.bttModule.Name = "bttModule";
            this.bttModule.Size = new System.Drawing.Size(53, 47);
            this.bttModule.TabIndex = 17;
            this.bttModule.Text = "%";
            this.bttModule.UseVisualStyleBackColor = true;
            this.bttModule.Click += new System.EventHandler(this.bttModule_Click);
            // 
            // bttDiv
            // 
            this.bttDiv.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDiv.Location = new System.Drawing.Point(89, 99);
            this.bttDiv.Name = "bttDiv";
            this.bttDiv.Size = new System.Drawing.Size(53, 47);
            this.bttDiv.TabIndex = 18;
            this.bttDiv.Text = "/";
            this.bttDiv.UseVisualStyleBackColor = true;
            this.bttDiv.Click += new System.EventHandler(this.bttDiv_Click);
            // 
            // bttReset
            // 
            this.bttReset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReset.Location = new System.Drawing.Point(145, 99);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(53, 47);
            this.bttReset.TabIndex = 19;
            this.bttReset.Text = "C";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.bttReset_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.Location = new System.Drawing.Point(202, 99);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(53, 47);
            this.bttDelete.TabIndex = 20;
            this.bttDelete.Text = "<";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 379);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttReset);
            this.Controls.Add(this.bttDiv);
            this.Controls.Add(this.bttModule);
            this.Controls.Add(this.bttResult);
            this.Controls.Add(this.bttAddition);
            this.Controls.Add(this.bttSubstract);
            this.Controls.Add(this.bttMultiply);
            this.Controls.Add(this.bttDot);
            this.Controls.Add(this.btt0);
            this.Controls.Add(this.btt9);
            this.Controls.Add(this.btt8);
            this.Controls.Add(this.btt7);
            this.Controls.Add(this.btt6);
            this.Controls.Add(this.btt5);
            this.Controls.Add(this.btt4);
            this.Controls.Add(this.btt3);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.resultBox);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.Button btt6;
        private System.Windows.Forms.Button btt5;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.Button btt9;
        private System.Windows.Forms.Button btt8;
        private System.Windows.Forms.Button btt7;
        private System.Windows.Forms.Button btt0;
        private System.Windows.Forms.Button bttDot;
        private System.Windows.Forms.Button bttMultiply;
        private System.Windows.Forms.Button bttSubstract;
        private System.Windows.Forms.Button bttAddition;
        private System.Windows.Forms.Button bttResult;
        private System.Windows.Forms.Button bttModule;
        private System.Windows.Forms.Button bttDiv;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.Button bttDelete;
    }
}

