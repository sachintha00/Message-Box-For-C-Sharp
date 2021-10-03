namespace MessageBocC_Sharp
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.btnInformation = new Guna.UI.WinForms.GunaButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnError = new Guna.UI.WinForms.GunaButton();
            this.btnWarning = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // btnInformation
            // 
            this.btnInformation.AnimationHoverSpeed = 0.07F;
            this.btnInformation.AnimationSpeed = 0.03F;
            this.btnInformation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnInformation.BorderColor = System.Drawing.Color.Black;
            this.btnInformation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInformation.FocusedColor = System.Drawing.Color.Empty;
            this.btnInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnInformation.Image")));
            this.btnInformation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInformation.Location = new System.Drawing.Point(66, 125);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(93)))), ((int)(((byte)(168)))));
            this.btnInformation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInformation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInformation.OnHoverImage = null;
            this.btnInformation.OnPressedColor = System.Drawing.Color.Black;
            this.btnInformation.Size = new System.Drawing.Size(206, 75);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "INFORMATION";
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click_1);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(506, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(82, 47);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // btnError
            // 
            this.btnError.AnimationHoverSpeed = 0.07F;
            this.btnError.AnimationSpeed = 0.03F;
            this.btnError.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(126)))));
            this.btnError.BorderColor = System.Drawing.Color.Black;
            this.btnError.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnError.FocusedColor = System.Drawing.Color.Empty;
            this.btnError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Image = ((System.Drawing.Image)(resources.GetObject("btnError.Image")));
            this.btnError.ImageSize = new System.Drawing.Size(20, 20);
            this.btnError.Location = new System.Drawing.Point(66, 223);
            this.btnError.Name = "btnError";
            this.btnError.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(126)))));
            this.btnError.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnError.OnHoverForeColor = System.Drawing.Color.White;
            this.btnError.OnHoverImage = null;
            this.btnError.OnPressedColor = System.Drawing.Color.Black;
            this.btnError.Size = new System.Drawing.Size(206, 75);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "ERROR";
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.AnimationHoverSpeed = 0.07F;
            this.btnWarning.AnimationSpeed = 0.03F;
            this.btnWarning.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(56)))));
            this.btnWarning.BorderColor = System.Drawing.Color.Black;
            this.btnWarning.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnWarning.FocusedColor = System.Drawing.Color.Empty;
            this.btnWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWarning.ForeColor = System.Drawing.Color.White;
            this.btnWarning.Image = ((System.Drawing.Image)(resources.GetObject("btnWarning.Image")));
            this.btnWarning.ImageSize = new System.Drawing.Size(20, 20);
            this.btnWarning.Location = new System.Drawing.Point(301, 223);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(56)))));
            this.btnWarning.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnWarning.OnHoverForeColor = System.Drawing.Color.White;
            this.btnWarning.OnHoverImage = null;
            this.btnWarning.OnPressedColor = System.Drawing.Color.Black;
            this.btnWarning.Size = new System.Drawing.Size(206, 75);
            this.btnWarning.TabIndex = 0;
            this.btnWarning.Text = "WARNING";
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(301, 125);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(206, 75);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "QUESTION";
            this.gunaButton1.Click += new System.EventHandler(this.btnQuestion);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 378);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnInformation;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI.WinForms.GunaButton btnError;
        private Guna.UI.WinForms.GunaButton btnWarning;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}

