namespace BodyForgeClient.Forms
{
    partial class WorkoutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workoutList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewWorkoutButton = new System.Windows.Forms.Button();
            this.deleteWorkout = new System.Windows.Forms.Button();
            this.addWorkoutButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.addWorkoutButton);
            this.panel2.Controls.Add(this.deleteWorkout);
            this.panel2.Controls.Add(this.viewWorkoutButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.workoutList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-27, -114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 737);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(284, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BodyForge Login Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(373, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "BodyForge";
            // 
            // workoutList
            // 
            this.workoutList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.workoutList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workoutList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutList.ForeColor = System.Drawing.Color.AliceBlue;
            this.workoutList.FormattingEnabled = true;
            this.workoutList.ItemHeight = 20;
            this.workoutList.Location = new System.Drawing.Point(100, 217);
            this.workoutList.Name = "workoutList";
            this.workoutList.Size = new System.Drawing.Size(715, 322);
            this.workoutList.TabIndex = 2;
            this.workoutList.SelectedIndexChanged += new System.EventHandler(this.workoutList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(96, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your workouts";
            // 
            // viewWorkoutButton
            // 
            this.viewWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.viewWorkoutButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.viewWorkoutButton.Location = new System.Drawing.Point(100, 545);
            this.viewWorkoutButton.Name = "viewWorkoutButton";
            this.viewWorkoutButton.Size = new System.Drawing.Size(112, 41);
            this.viewWorkoutButton.TabIndex = 6;
            this.viewWorkoutButton.Text = "View Workout";
            this.viewWorkoutButton.UseVisualStyleBackColor = false;
            // 
            // deleteWorkout
            // 
            this.deleteWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.deleteWorkout.ForeColor = System.Drawing.Color.AliceBlue;
            this.deleteWorkout.Location = new System.Drawing.Point(218, 545);
            this.deleteWorkout.Name = "deleteWorkout";
            this.deleteWorkout.Size = new System.Drawing.Size(112, 41);
            this.deleteWorkout.TabIndex = 7;
            this.deleteWorkout.Text = "Delete Workout -";
            this.deleteWorkout.UseVisualStyleBackColor = false;
            this.deleteWorkout.Click += new System.EventHandler(this.deleteWorkout_Click);
            // 
            // addWorkoutButton
            // 
            this.addWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.addWorkoutButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.addWorkoutButton.Location = new System.Drawing.Point(703, 545);
            this.addWorkoutButton.Name = "addWorkoutButton";
            this.addWorkoutButton.Size = new System.Drawing.Size(112, 41);
            this.addWorkoutButton.TabIndex = 8;
            this.addWorkoutButton.Text = "Add new workout +";
            this.addWorkoutButton.UseVisualStyleBackColor = false;
            this.addWorkoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkoutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 594);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutMenu";
            this.Text = "WorkoutMenu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox workoutList;
        private System.Windows.Forms.Button addWorkoutButton;
        private System.Windows.Forms.Button deleteWorkout;
        private System.Windows.Forms.Button viewWorkoutButton;
    }
}