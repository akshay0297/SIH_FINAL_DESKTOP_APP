namespace testingDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.srcPincode = new System.Windows.Forms.TextBox();
            this.service_type = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.srcState = new System.Windows.Forms.TextBox();
            this.srcCity = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.pincode = new System.Windows.Forms.Label();
            this.destPincode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.destCity = new System.Windows.Forms.TextBox();
            this.destState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.length = new System.Windows.Forms.Label();
            this.lengtht = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.heightt = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.widtht = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.weightText = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 85);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(241, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 35;
            this.label1.Text = "Calculate Postage";
            // 
            // srcPincode
            // 
            this.srcPincode.Location = new System.Drawing.Point(190, 150);
            this.srcPincode.Name = "srcPincode";
            this.srcPincode.Size = new System.Drawing.Size(100, 20);
            this.srcPincode.TabIndex = 42;
            this.srcPincode.Text = "400001";
            this.srcPincode.TextChanged += new System.EventHandler(this.srcPincode_TextChanged_1);
            // 
            // service_type
            // 
            this.service_type.AutoSize = true;
            this.service_type.Location = new System.Drawing.Point(250, 239);
            this.service_type.Name = "service_type";
            this.service_type.Size = new System.Drawing.Size(70, 13);
            this.service_type.TabIndex = 32;
            this.service_type.Text = "Service Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(76, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 124);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Source*";
            // 
            // srcState
            // 
            this.srcState.Location = new System.Drawing.Point(190, 185);
            this.srcState.Name = "srcState";
            this.srcState.ReadOnly = true;
            this.srcState.Size = new System.Drawing.Size(100, 20);
            this.srcState.TabIndex = 37;
            this.srcState.Text = "Maharastra";
            // 
            // srcCity
            // 
            this.srcCity.Location = new System.Drawing.Point(190, 220);
            this.srcCity.Name = "srcCity";
            this.srcCity.ReadOnly = true;
            this.srcCity.Size = new System.Drawing.Size(100, 20);
            this.srcCity.TabIndex = 38;
            this.srcCity.Text = "Mumbai";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.Transparent;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(126, 187);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(44, 16);
            this.state.TabIndex = 39;
            this.state.Text = "State*";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(97, 222);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(79, 16);
            this.city.TabIndex = 40;
            this.city.Text = "City/District*";
            // 
            // pincode
            // 
            this.pincode.AutoSize = true;
            this.pincode.BackColor = System.Drawing.Color.Transparent;
            this.pincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincode.Location = new System.Drawing.Point(112, 152);
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(63, 16);
            this.pincode.TabIndex = 41;
            this.pincode.Text = "Pincode*";
            // 
            // destPincode
            // 
            this.destPincode.Location = new System.Drawing.Point(580, 150);
            this.destPincode.Name = "destPincode";
            this.destPincode.Size = new System.Drawing.Size(100, 20);
            this.destPincode.TabIndex = 51;
            this.destPincode.Text = "500001";
            this.destPincode.TextChanged += new System.EventHandler(this.destPincode_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Pincode*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "City/District*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "State*";
            // 
            // destCity
            // 
            this.destCity.Location = new System.Drawing.Point(580, 220);
            this.destCity.Name = "destCity";
            this.destCity.ReadOnly = true;
            this.destCity.Size = new System.Drawing.Size(100, 20);
            this.destCity.TabIndex = 47;
            this.destCity.Text = "Hyderabad";
            // 
            // destState
            // 
            this.destState.Location = new System.Drawing.Point(580, 185);
            this.destState.Name = "destState";
            this.destState.ReadOnly = true;
            this.destState.Size = new System.Drawing.Size(100, 20);
            this.destState.TabIndex = 46;
            this.destState.Text = "Telangana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Destination*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(464, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 124);
            this.panel2.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Service Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Article Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Letter",
            "Book Packet",
            "Parcel",
            "Speed Post Letter"});
            this.comboBox1.Location = new System.Drawing.Point(372, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.BackColor = System.Drawing.Color.Transparent;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length.Location = new System.Drawing.Point(67, 428);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(90, 16);
            this.length.TabIndex = 62;
            this.length.Text = "Length (in cm)";
            this.length.Visible = false;
            // 
            // lengtht
            // 
            this.lengtht.Location = new System.Drawing.Point(178, 427);
            this.lengtht.Name = "lengtht";
            this.lengtht.Size = new System.Drawing.Size(100, 20);
            this.lengtht.TabIndex = 61;
            this.lengtht.Text = "0";
            this.lengtht.Visible = false;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.BackColor = System.Drawing.Color.Transparent;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(68, 392);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(89, 16);
            this.height.TabIndex = 60;
            this.height.Text = "Height (in cm)";
            this.height.Visible = false;
            this.height.Click += new System.EventHandler(this.height_Click);
            // 
            // heightt
            // 
            this.heightt.Location = new System.Drawing.Point(178, 392);
            this.heightt.Name = "heightt";
            this.heightt.Size = new System.Drawing.Size(100, 20);
            this.heightt.TabIndex = 59;
            this.heightt.Text = "0";
            this.heightt.Visible = false;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.BackColor = System.Drawing.Color.Transparent;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(73, 358);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(84, 16);
            this.width.TabIndex = 58;
            this.width.Text = "Width (in cm)";
            this.width.Visible = false;
            // 
            // widtht
            // 
            this.widtht.Location = new System.Drawing.Point(178, 357);
            this.widtht.Name = "widtht";
            this.widtht.Size = new System.Drawing.Size(100, 20);
            this.widtht.TabIndex = 57;
            this.widtht.Text = "0";
            this.widtht.Visible = false;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.BackColor = System.Drawing.Color.Transparent;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(59, 324);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(98, 16);
            this.weight.TabIndex = 56;
            this.weight.Text = "Weight (in gm)*";
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(178, 322);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(100, 20);
            this.weightText.TabIndex = 55;
            this.weightText.Text = "0";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Maroon;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.Color.White;
            this.calculate.Location = new System.Drawing.Point(322, 455);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(158, 37);
            this.calculate.TabIndex = 63;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 511);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.length);
            this.Controls.Add(this.lengtht);
            this.Controls.Add(this.height);
            this.Controls.Add(this.heightt);
            this.Controls.Add(this.width);
            this.Controls.Add(this.widtht);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.destPincode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destCity);
            this.Controls.Add(this.destState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.srcPincode);
            this.Controls.Add(this.pincode);
            this.Controls.Add(this.city);
            this.Controls.Add(this.state);
            this.Controls.Add(this.srcCity);
            this.Controls.Add(this.srcState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.service_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srcPincode;
        private System.Windows.Forms.Label service_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srcState;
        private System.Windows.Forms.TextBox srcCity;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label pincode;
        private System.Windows.Forms.TextBox destPincode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox destCity;
        private System.Windows.Forms.TextBox destState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox lengtht;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox heightt;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.TextBox widtht;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.Button calculate;
    }
}

