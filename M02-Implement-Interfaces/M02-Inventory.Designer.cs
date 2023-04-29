using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace M02_Implement_Interfaces
{
    partial class Inventory
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            allButton = new Button();
            equipButton = new Button();
            consumeButton = new Button();
            craftButton = new Button();
            splitter1 = new Splitter();
            equippedButton = new Button();
            consumedButton = new Button();
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            hpLabel = new Label();
            hpValue = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            attackLabel = new Label();
            attackValue = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            magicLabel = new Label();
            magicValue = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            defenseLabel = new Label();
            defenseValue = new Label();
            flowLayoutPanel7 = new FlowLayoutPanel();
            loadLabel = new Label();
            loadValue = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            speedLabel = new Label();
            speedValue = new Label();
            flowLayoutPanel9 = new FlowLayoutPanel();
            manaLabel = new Label();
            manaValue = new Label();
            selectButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(allButton);
            flowLayoutPanel1.Controls.Add(equipButton);
            flowLayoutPanel1.Controls.Add(consumeButton);
            flowLayoutPanel1.Controls.Add(craftButton);
            flowLayoutPanel1.Controls.Add(splitter1);
            flowLayoutPanel1.Controls.Add(equippedButton);
            flowLayoutPanel1.Controls.Add(consumedButton);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3);
            flowLayoutPanel1.Size = new Size(2130, 81);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // allButton
            // 
            allButton.BackColor = SystemColors.Control;
            allButton.Location = new Point(6, 6);
            allButton.Name = "allButton";
            allButton.Size = new Size(225, 69);
            allButton.TabIndex = 0;
            allButton.Text = "All";
            allButton.UseVisualStyleBackColor = true;
            allButton.Click += allButton_Click;
            // 
            // equipButton
            // 
            equipButton.BackColor = SystemColors.Control;
            equipButton.Location = new Point(237, 6);
            equipButton.Name = "equipButton";
            equipButton.Size = new Size(225, 69);
            equipButton.TabIndex = 1;
            equipButton.Text = "Equipables";
            equipButton.UseVisualStyleBackColor = true;
            equipButton.Click += equipableButton_Click;
            // 
            // consumeButton
            // 
            consumeButton.BackColor = SystemColors.Control;
            consumeButton.Location = new Point(468, 6);
            consumeButton.Name = "consumeButton";
            consumeButton.Size = new Size(243, 69);
            consumeButton.TabIndex = 2;
            consumeButton.Text = "Consumables";
            consumeButton.UseVisualStyleBackColor = true;
            consumeButton.Click += consumableButton_Click;
            // 
            // craftButton
            // 
            craftButton.BackColor = SystemColors.Control;
            craftButton.Location = new Point(717, 6);
            craftButton.Name = "craftButton";
            craftButton.Size = new Size(225, 69);
            craftButton.TabIndex = 3;
            craftButton.Text = "Craftables";
            craftButton.UseVisualStyleBackColor = true;
            craftButton.Click += craftButton_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(948, 6);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(711, 69);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // equippedButton
            // 
            equippedButton.Enabled = false;
            equippedButton.Location = new Point(1665, 6);
            equippedButton.Name = "equippedButton";
            equippedButton.Size = new Size(225, 69);
            equippedButton.TabIndex = 5;
            equippedButton.Text = "Equipped";
            equippedButton.UseVisualStyleBackColor = true;
            // 
            // consumedButton
            // 
            consumedButton.Enabled = false;
            consumedButton.Location = new Point(1896, 6);
            consumedButton.Name = "consumedButton";
            consumedButton.Size = new Size(225, 69);
            consumedButton.TabIndex = 6;
            consumedButton.Text = "Consumed";
            consumedButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 81);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            splitContainer1.Panel1.Padding = new Padding(0, 0, 0, 50);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Size = new Size(2130, 1011);
            splitContainer1.SplitterDistance = 1732;
            splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1732, 961);
            listView1.TabIndex = 0;
            listView1.TabStop = false;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel2.Controls.Add(selectButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(3, 3, 0, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(3, 10, 3, 0);
            flowLayoutPanel2.Size = new Size(394, 1011);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(382, 48);
            label1.TabIndex = 2;
            label1.Text = "Player Stats";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(hpLabel);
            flowLayoutPanel3.Controls.Add(hpValue);
            flowLayoutPanel3.Location = new Point(6, 73);
            flowLayoutPanel3.Margin = new Padding(3, 15, 3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(376, 49);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // hpLabel
            // 
            hpLabel.AutoSize = true;
            hpLabel.Location = new Point(3, 0);
            hpLabel.Name = "hpLabel";
            hpLabel.Size = new Size(84, 48);
            hpLabel.TabIndex = 3;
            hpLabel.Text = "HP :";
            // 
            // hpValue
            // 
            hpValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hpValue.AutoSize = true;
            hpValue.Location = new Point(93, 0);
            hpValue.Name = "hpValue";
            hpValue.Size = new Size(39, 48);
            hpValue.TabIndex = 4;
            hpValue.Text = "0";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(attackLabel);
            flowLayoutPanel4.Controls.Add(attackValue);
            flowLayoutPanel4.Location = new Point(6, 128);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(376, 48);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // attackLabel
            // 
            attackLabel.AutoSize = true;
            attackLabel.Location = new Point(3, 0);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new Size(138, 48);
            attackLabel.TabIndex = 5;
            attackLabel.Text = "Attack :";
            // 
            // attackValue
            // 
            attackValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            attackValue.AutoSize = true;
            attackValue.Location = new Point(147, 0);
            attackValue.Name = "attackValue";
            attackValue.Size = new Size(39, 48);
            attackValue.TabIndex = 7;
            attackValue.Text = "0";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(magicLabel);
            flowLayoutPanel5.Controls.Add(magicValue);
            flowLayoutPanel5.Location = new Point(6, 182);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(376, 48);
            flowLayoutPanel5.TabIndex = 8;
            // 
            // magicLabel
            // 
            magicLabel.AutoSize = true;
            magicLabel.Location = new Point(3, 0);
            magicLabel.Name = "magicLabel";
            magicLabel.Size = new Size(135, 48);
            magicLabel.TabIndex = 8;
            magicLabel.Text = "Magic :";
            // 
            // magicValue
            // 
            magicValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            magicValue.AutoSize = true;
            magicValue.Location = new Point(144, 0);
            magicValue.Name = "magicValue";
            magicValue.Size = new Size(39, 48);
            magicValue.TabIndex = 9;
            magicValue.Text = "0";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(defenseLabel);
            flowLayoutPanel6.Controls.Add(defenseValue);
            flowLayoutPanel6.Location = new Point(6, 236);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(376, 48);
            flowLayoutPanel6.TabIndex = 9;
            // 
            // defenseLabel
            // 
            defenseLabel.AutoSize = true;
            defenseLabel.Location = new Point(3, 0);
            defenseLabel.Name = "defenseLabel";
            defenseLabel.Size = new Size(166, 48);
            defenseLabel.TabIndex = 14;
            defenseLabel.Text = "Defense :";
            // 
            // defenseValue
            // 
            defenseValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            defenseValue.AutoSize = true;
            defenseValue.Location = new Point(175, 0);
            defenseValue.Name = "defenseValue";
            defenseValue.Size = new Size(39, 48);
            defenseValue.TabIndex = 15;
            defenseValue.Text = "0";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(loadLabel);
            flowLayoutPanel7.Controls.Add(loadValue);
            flowLayoutPanel7.Location = new Point(6, 290);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(376, 48);
            flowLayoutPanel7.TabIndex = 10;
            // 
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.Location = new Point(3, 0);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(115, 48);
            loadLabel.TabIndex = 10;
            loadLabel.Text = "Load :";
            // 
            // loadValue
            // 
            loadValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadValue.AutoSize = true;
            loadValue.Location = new Point(124, 0);
            loadValue.Name = "loadValue";
            loadValue.Size = new Size(39, 48);
            loadValue.TabIndex = 11;
            loadValue.Text = "0";
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(speedLabel);
            flowLayoutPanel8.Controls.Add(speedValue);
            flowLayoutPanel8.Location = new Point(6, 344);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(376, 48);
            flowLayoutPanel8.TabIndex = 11;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(3, 0);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(137, 48);
            speedLabel.TabIndex = 12;
            speedLabel.Text = "Speed :";
            // 
            // speedValue
            // 
            speedValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            speedValue.AutoSize = true;
            speedValue.Location = new Point(146, 0);
            speedValue.Name = "speedValue";
            speedValue.Size = new Size(39, 48);
            speedValue.TabIndex = 13;
            speedValue.Text = "0";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.Controls.Add(manaLabel);
            flowLayoutPanel9.Controls.Add(manaValue);
            flowLayoutPanel9.Location = new Point(6, 398);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(376, 48);
            flowLayoutPanel9.TabIndex = 12;
            // 
            // manaLabel
            // 
            manaLabel.AutoSize = true;
            manaLabel.Location = new Point(3, 0);
            manaLabel.Name = "manaLabel";
            manaLabel.Size = new Size(126, 48);
            manaLabel.TabIndex = 12;
            manaLabel.Text = "Mana :";
            // 
            // manaValue
            // 
            manaValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            manaValue.AutoSize = true;
            manaValue.Location = new Point(135, 0);
            manaValue.Name = "manaValue";
            manaValue.Size = new Size(39, 48);
            manaValue.TabIndex = 13;
            manaValue.Text = "0";
            // 
            // selectButton
            // 
            selectButton.AutoSize = true;
            selectButton.Location = new Point(6, 479);
            selectButton.Margin = new Padding(3, 30, 0, 10);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(379, 69);
            selectButton.TabIndex = 0;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2130, 1092);
            Controls.Add(splitContainer1);
            Controls.Add(flowLayoutPanel1);
            Name = "Inventory";
            Text = "M02 Inventory";
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button allButton;
        private Button equipButton;
        private Button consumeButton;
        private Button craftButton;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button selectButton;
        private ListView listView1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label hpLabel;
        private Label hpValue;
        private Label attackLabel;
        private Label attackValue;
        private Label magicLabel;
        private Label magicValue;
        private Label loadLabel;
        private Label loadValue;
        private Label speedLabel;
        private Label speedValue;
        private Label defenseLabel;
        private Label defenseValue;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label manaLabel;
        private Label manaValue;
        private Splitter splitter1;
        private Button equippedButton;
        private Button consumedButton;
    }
}