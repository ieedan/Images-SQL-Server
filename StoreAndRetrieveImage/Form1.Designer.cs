namespace StoreAndRetrieveImage
{
    partial class Form1
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
            this.image_store = new System.Windows.Forms.PictureBox();
            this.image_retrieve = new System.Windows.Forms.PictureBox();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.num_imgid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.image_store)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_retrieve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgid)).BeginInit();
            this.SuspendLayout();
            // 
            // image_store
            // 
            this.image_store.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_store.Location = new System.Drawing.Point(23, 99);
            this.image_store.Name = "image_store";
            this.image_store.Size = new System.Drawing.Size(327, 250);
            this.image_store.TabIndex = 0;
            this.image_store.TabStop = false;
            this.image_store.Click += new System.EventHandler(this.image_store_Click);
            // 
            // image_retrieve
            // 
            this.image_retrieve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_retrieve.Location = new System.Drawing.Point(553, 99);
            this.image_retrieve.Name = "image_retrieve";
            this.image_retrieve.Size = new System.Drawing.Size(327, 250);
            this.image_retrieve.TabIndex = 1;
            this.image_retrieve.TabStop = false;
            // 
            // btn_store
            // 
            this.btn_store.Location = new System.Drawing.Point(113, 397);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(115, 73);
            this.btn_store.TabIndex = 2;
            this.btn_store.Text = "Store";
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(658, 397);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(115, 73);
            this.btn_retrieve.TabIndex = 3;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // num_imgid
            // 
            this.num_imgid.Location = new System.Drawing.Point(658, 356);
            this.num_imgid.Name = "num_imgid";
            this.num_imgid.Size = new System.Drawing.Size(120, 26);
            this.num_imgid.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 554);
            this.Controls.Add(this.num_imgid);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.image_retrieve);
            this.Controls.Add(this.image_store);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image_store)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_retrieve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_imgid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_store;
        private System.Windows.Forms.PictureBox image_retrieve;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_retrieve;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown num_imgid;
    }
}

