namespace CrapsGame
{
    partial class CrapsLogin
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.editPlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.playerStatusLabel = new System.Windows.Forms.Label();
            this.clearPlayerScoreHistoryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.crapsDataSet = new CrapsGame.CrapsDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new CrapsGame.CrapsDataSetTableAdapters.PlayersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(133, 77);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(67, 13);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player Name";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(651, 117);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(248, 69);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(212, 20);
            this.playerTextBox.TabIndex = 3;
            // 
            // editPlayerButton
            // 
            this.editPlayerButton.Location = new System.Drawing.Point(651, 162);
            this.editPlayerButton.Name = "editPlayerButton";
            this.editPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.editPlayerButton.TabIndex = 4;
            this.editPlayerButton.Text = "Edit";
            this.editPlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(651, 67);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 5;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Location = new System.Drawing.Point(651, 217);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.removePlayerButton.TabIndex = 6;
            this.removePlayerButton.Text = "Delete Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // playerStatusLabel
            // 
            this.playerStatusLabel.AutoSize = true;
            this.playerStatusLabel.Location = new System.Drawing.Point(136, 13);
            this.playerStatusLabel.Name = "playerStatusLabel";
            this.playerStatusLabel.Size = new System.Drawing.Size(75, 13);
            this.playerStatusLabel.TabIndex = 7;
            this.playerStatusLabel.Text = "Not Logged In";
            // 
            // clearPlayerScoreHistoryButton
            // 
            this.clearPlayerScoreHistoryButton.Location = new System.Drawing.Point(651, 273);
            this.clearPlayerScoreHistoryButton.Name = "clearPlayerScoreHistoryButton";
            this.clearPlayerScoreHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.clearPlayerScoreHistoryButton.TabIndex = 8;
            this.clearPlayerScoreHistoryButton.Text = "Clear History";
            this.clearPlayerScoreHistoryButton.UseVisualStyleBackColor = true;
            this.clearPlayerScoreHistoryButton.Click += new System.EventHandler(this.ClearPlayerScoreHistoryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(651, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // crapsDataSet
            // 
            this.crapsDataSet.DataSetName = "CrapsDataSet";
            this.crapsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.crapsDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // CrapsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearPlayerScoreHistoryButton);
            this.Controls.Add(this.playerStatusLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.editPlayerButton);
            this.Controls.Add(this.playerTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.playerLabel);
            this.Name = "CrapsLogin";
            this.Text = "CrapsLogin";
            this.Load += new System.EventHandler(this.CrapsLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crapsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox playerTextBox;
        private System.Windows.Forms.Button editPlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Label playerStatusLabel;
        private System.Windows.Forms.Button clearPlayerScoreHistoryButton;
        private System.Windows.Forms.Button exitButton;
        private CrapsDataSet crapsDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private CrapsDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}