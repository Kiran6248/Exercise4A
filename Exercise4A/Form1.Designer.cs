namespace Exercise4A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbExtraToppings = new System.Windows.Forms.GroupBox();
            this.cbSalami = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbSweetcorn = new System.Windows.Forms.CheckBox();
            this.cbJalapenos = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbPinapple = new System.Windows.Forms.CheckBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtSpecialRequirements = new System.Windows.Forms.TextBox();
            this.lblSpecialRequirements = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbExtraToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order a Pizza";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 17;
            this.lstName.Items.AddRange(new object[] {
            "Indian Apache",
            "Mexican Pepper Volcano",
            "All Day Breakfast",
            "Bacon Apache",
            "Buffalo",
            "Cajun Apache",
            "Chicken Apache",
            "Geronimo",
            "Hot Apache",
            "Sitting Bull",
            "Texas Beef Fiesta",
            "Tomahawk",
            "Vegetarian",
            "Wigwammer"});
            this.lstName.Location = new System.Drawing.Point(37, 102);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(179, 259);
            this.lstName.TabIndex = 1;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // gbExtraToppings
            // 
            this.gbExtraToppings.Controls.Add(this.cbSalami);
            this.gbExtraToppings.Controls.Add(this.cbExtraCheese);
            this.gbExtraToppings.Controls.Add(this.cbGreenPeppers);
            this.gbExtraToppings.Controls.Add(this.cbSweetcorn);
            this.gbExtraToppings.Controls.Add(this.cbJalapenos);
            this.gbExtraToppings.Controls.Add(this.cbMushrooms);
            this.gbExtraToppings.Controls.Add(this.cbPinapple);
            this.gbExtraToppings.Controls.Add(this.cbChicken);
            this.gbExtraToppings.Controls.Add(this.cbBacon);
            this.gbExtraToppings.Controls.Add(this.cbSausage);
            this.gbExtraToppings.Controls.Add(this.cbHam);
            this.gbExtraToppings.Controls.Add(this.cbPepperoni);
            this.gbExtraToppings.Controls.Add(this.cbOnion);
            this.gbExtraToppings.Controls.Add(this.cbTomatoes);
            this.gbExtraToppings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbExtraToppings.Location = new System.Drawing.Point(265, 90);
            this.gbExtraToppings.Name = "gbExtraToppings";
            this.gbExtraToppings.Size = new System.Drawing.Size(275, 272);
            this.gbExtraToppings.TabIndex = 3;
            this.gbExtraToppings.TabStop = false;
            this.gbExtraToppings.Text = "Extra Toppings";
            // 
            // cbSalami
            // 
            this.cbSalami.AutoSize = true;
            this.cbSalami.Location = new System.Drawing.Point(144, 244);
            this.cbSalami.Name = "cbSalami";
            this.cbSalami.Size = new System.Drawing.Size(67, 23);
            this.cbSalami.TabIndex = 13;
            this.cbSalami.Text = "Salami";
            this.cbSalami.UseVisualStyleBackColor = true;
            this.cbSalami.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(145, 215);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(106, 23);
            this.cbExtraCheese.TabIndex = 12;
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(145, 182);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(117, 23);
            this.cbGreenPeppers.TabIndex = 11;
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbSweetcorn
            // 
            this.cbSweetcorn.AutoSize = true;
            this.cbSweetcorn.Location = new System.Drawing.Point(145, 145);
            this.cbSweetcorn.Name = "cbSweetcorn";
            this.cbSweetcorn.Size = new System.Drawing.Size(91, 23);
            this.cbSweetcorn.TabIndex = 10;
            this.cbSweetcorn.Text = "Sweetcorn";
            this.cbSweetcorn.UseVisualStyleBackColor = true;
            this.cbSweetcorn.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbJalapenos
            // 
            this.cbJalapenos.AutoSize = true;
            this.cbJalapenos.Location = new System.Drawing.Point(147, 107);
            this.cbJalapenos.Name = "cbJalapenos";
            this.cbJalapenos.Size = new System.Drawing.Size(87, 23);
            this.cbJalapenos.TabIndex = 9;
            this.cbJalapenos.Text = "Jalapenos";
            this.cbJalapenos.UseVisualStyleBackColor = true;
            this.cbJalapenos.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(148, 73);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(102, 23);
            this.cbMushrooms.TabIndex = 8;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbPinapple
            // 
            this.cbPinapple.AutoSize = true;
            this.cbPinapple.Location = new System.Drawing.Point(147, 33);
            this.cbPinapple.Name = "cbPinapple";
            this.cbPinapple.Size = new System.Drawing.Size(80, 23);
            this.cbPinapple.TabIndex = 7;
            this.cbPinapple.Text = "Pinapple";
            this.cbPinapple.UseVisualStyleBackColor = true;
            this.cbPinapple.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(12, 239);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(76, 23);
            this.cbChicken.TabIndex = 6;
            this.cbChicken.Text = "Chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            this.cbChicken.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(11, 210);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(65, 23);
            this.cbBacon.TabIndex = 5;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            this.cbBacon.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(11, 178);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(78, 23);
            this.cbSausage.TabIndex = 4;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(11, 142);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(57, 23);
            this.cbHam.TabIndex = 3;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            this.cbHam.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(12, 105);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(89, 23);
            this.cbPepperoni.TabIndex = 2;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(11, 69);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(66, 23);
            this.cbOnion.TabIndex = 1;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(11, 34);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(87, 23);
            this.cbTomatoes.TabIndex = 0;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.Click += new System.EventHandler(this.ExtraToppingClicked);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbPersonal);
            this.gbSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSize.Location = new System.Drawing.Point(599, 95);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(163, 162);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(33, 121);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(61, 23);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.Click += new System.EventHandler(this.PizzaSizeClicked);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(32, 92);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(78, 23);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.Click += new System.EventHandler(this.PizzaSizeClicked);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(32, 61);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(59, 23);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.Click += new System.EventHandler(this.PizzaSizeClicked);
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(31, 31);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(78, 23);
            this.rbPersonal.TabIndex = 0;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.Click += new System.EventHandler(this.PizzaSizeClicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(618, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 48);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(618, 338);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(129, 48);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtSpecialRequirements
            // 
            this.txtSpecialRequirements.Location = new System.Drawing.Point(40, 432);
            this.txtSpecialRequirements.Multiline = true;
            this.txtSpecialRequirements.Name = "txtSpecialRequirements";
            this.txtSpecialRequirements.Size = new System.Drawing.Size(500, 64);
            this.txtSpecialRequirements.TabIndex = 7;
            // 
            // lblSpecialRequirements
            // 
            this.lblSpecialRequirements.AutoSize = true;
            this.lblSpecialRequirements.Location = new System.Drawing.Point(42, 403);
            this.lblSpecialRequirements.Name = "lblSpecialRequirements";
            this.lblSpecialRequirements.Size = new System.Drawing.Size(138, 19);
            this.lblSpecialRequirements.TabIndex = 8;
            this.lblSpecialRequirements.Text = "Special Requirements";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(636, 432);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(641, 459);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(25, 30);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSpecialRequirements);
            this.Controls.Add(this.txtSpecialRequirements);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbExtraToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbExtraToppings.ResumeLayout(false);
            this.gbExtraToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstName;
        private Label label2;
        private GroupBox gbExtraToppings;
        private CheckBox cbSalami;
        private CheckBox cbExtraCheese;
        private CheckBox cbGreenPeppers;
        private CheckBox cbSweetcorn;
        private CheckBox cbJalapenos;
        private CheckBox cbMushrooms;
        private CheckBox cbPinapple;
        private CheckBox cbChicken;
        private CheckBox cbBacon;
        private CheckBox cbSausage;
        private CheckBox cbHam;
        private CheckBox cbPepperoni;
        private CheckBox cbOnion;
        private CheckBox cbTomatoes;
        private GroupBox gbSize;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private RadioButton rbPersonal;
        private RadioButton rbLarge;
        private Button btnReset;
        private Button btnPlaceOrder;
        private TextBox txtSpecialRequirements;
        private Label lblSpecialRequirements;
        private Label lblPrice;
        private Label lblTotalPrice;
    }
}