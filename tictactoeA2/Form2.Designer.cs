namespace tictactoeA2
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTesting1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnHome.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Crimson;
            this.btnHome.Location = new System.Drawing.Point(32, 630);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTesting1
            // 
            this.btnTesting1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTesting1.Location = new System.Drawing.Point(138, 239);
            this.btnTesting1.Name = "btnTesting1";
            this.btnTesting1.Size = new System.Drawing.Size(110, 110);
            this.btnTesting1.TabIndex = 1;
            this.btnTesting1.UseVisualStyleBackColor = true;
            this.btnTesting1.Click += new System.EventHandler(this.btnTesting1_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tictactoeA2.Properties.Resources.Play_Background;
            this.ClientSize = new System.Drawing.Size(635, 715);
            this.Controls.Add(this.btnTesting1);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHome;
        private Button btnTesting1;
    }
}