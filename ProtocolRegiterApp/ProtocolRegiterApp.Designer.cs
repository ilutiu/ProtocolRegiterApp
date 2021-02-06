
namespace ProtocolRegiterApp
{
    partial class ProtocolRegiterApp
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
            this.lblParams = new System.Windows.Forms.Label();
            this.lblParamValues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(133, 79);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(63, 13);
            this.lblParams.TabIndex = 0;
            this.lblParams.Text = "Parameters:";
            // 
            // lblParamValues
            // 
            this.lblParamValues.AutoSize = true;
            this.lblParamValues.Location = new System.Drawing.Point(203, 79);
            this.lblParamValues.Name = "lblParamValues";
            this.lblParamValues.Size = new System.Drawing.Size(0, 13);
            this.lblParamValues.TabIndex = 1;
            // 
            // ProtocolRegiterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblParamValues);
            this.Controls.Add(this.lblParams);
            this.Name = "ProtocolRegiterApp";
            this.Text = "ProtocolRegiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Label lblParamValues;
    }
}

