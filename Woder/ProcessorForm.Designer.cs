using System.Windows.Forms;

namespace Woder
{
    partial class ProcessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessorForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.labelInputData = new System.Windows.Forms.Label();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.labelInputEncoding = new System.Windows.Forms.Label();
            this.comboBoxInputEncoding = new System.Windows.Forms.ComboBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.textBoxOutputData = new System.Windows.Forms.TextBox();
            this.labelOutputEncoding = new System.Windows.Forms.Label();
            this.comboBoxOutputEncoding = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 432);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxInput.Controls.Add(this.buttonProcess);
            this.groupBoxInput.Controls.Add(this.labelInputData);
            this.groupBoxInput.Controls.Add(this.textBoxInputData);
            this.groupBoxInput.Controls.Add(this.labelInputEncoding);
            this.groupBoxInput.Controls.Add(this.comboBoxInputEncoding);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(1054, 214);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProcess.Location = new System.Drawing.Point(6, 185);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelInputData.Location = new System.Drawing.Point(6, 67);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(57, 13);
            this.labelInputData.TabIndex = 3;
            this.labelInputData.Text = "Input Data";
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputData.Location = new System.Drawing.Point(9, 83);
            this.textBoxInputData.Multiline = true;
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(1039, 96);
            this.textBoxInputData.TabIndex = 2;
            // 
            // labelInputEncoding
            // 
            this.labelInputEncoding.AutoSize = true;
            this.labelInputEncoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelInputEncoding.Location = new System.Drawing.Point(6, 27);
            this.labelInputEncoding.Name = "labelInputEncoding";
            this.labelInputEncoding.Size = new System.Drawing.Size(79, 13);
            this.labelInputEncoding.TabIndex = 1;
            this.labelInputEncoding.Text = "Input Encoding";
            // 
            // comboBoxInputEncoding
            // 
            this.comboBoxInputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputEncoding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxInputEncoding.FormattingEnabled = true;
            this.comboBoxInputEncoding.Location = new System.Drawing.Point(9, 43);
            this.comboBoxInputEncoding.Name = "comboBoxInputEncoding";
            this.comboBoxInputEncoding.Size = new System.Drawing.Size(139, 21);
            this.comboBoxInputEncoding.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOutput.Controls.Add(this.buttonExit);
            this.groupBoxOutput.Controls.Add(this.labelOutputData);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputData);
            this.groupBoxOutput.Controls.Add(this.labelOutputEncoding);
            this.groupBoxOutput.Controls.Add(this.comboBoxOutputEncoding);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(1054, 214);
            this.groupBoxOutput.TabIndex = 4;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Location = new System.Drawing.Point(9, 185);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(6, 67);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(65, 13);
            this.labelOutputData.TabIndex = 5;
            this.labelOutputData.Text = "Output Data";
            // 
            // textBoxOutputData
            // 
            this.textBoxOutputData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputData.Location = new System.Drawing.Point(9, 83);
            this.textBoxOutputData.Multiline = true;
            this.textBoxOutputData.Name = "textBoxOutputData";
            this.textBoxOutputData.Size = new System.Drawing.Size(1039, 96);
            this.textBoxOutputData.TabIndex = 4;
            // 
            // labelOutputEncoding
            // 
            this.labelOutputEncoding.AutoSize = true;
            this.labelOutputEncoding.Location = new System.Drawing.Point(6, 27);
            this.labelOutputEncoding.Name = "labelOutputEncoding";
            this.labelOutputEncoding.Size = new System.Drawing.Size(87, 13);
            this.labelOutputEncoding.TabIndex = 1;
            this.labelOutputEncoding.Text = "Output Encoding";
            // 
            // comboBoxOutputEncoding
            // 
            this.comboBoxOutputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputEncoding.FormattingEnabled = true;
            this.comboBoxOutputEncoding.Location = new System.Drawing.Point(9, 43);
            this.comboBoxOutputEncoding.Name = "comboBoxOutputEncoding";
            this.comboBoxOutputEncoding.Size = new System.Drawing.Size(139, 21);
            this.comboBoxOutputEncoding.TabIndex = 0;
            // 
            // ProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 432);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessorForm";
            this.Text = "Woder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Label labelInputEncoding;
        private System.Windows.Forms.ComboBox comboBoxInputEncoding;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelOutputData;
        private System.Windows.Forms.TextBox textBoxOutputData;
        private System.Windows.Forms.Label labelOutputEncoding;
        private System.Windows.Forms.ComboBox comboBoxOutputEncoding;
        private Button buttonExit;
    }
}

