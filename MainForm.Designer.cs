using System.Windows.Forms;

namespace TestUU
{
    partial class MainForm
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
            this.textBoxTCP = new System.Windows.Forms.TextBox();
            this.textBoxUDP = new System.Windows.Forms.TextBox();
            this.labelTCP = new System.Windows.Forms.Label();
            this.labelUDP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTcpUS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddressARM = new IPAddressControlLib.IPAddressControl();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.ipAddressControl = new IPAddressControlLib.IPAddressControl();
            this.labelNetwokSettings = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxB3Auto = new System.Windows.Forms.CheckBox();
            this.buyttonB3 = new System.Windows.Forms.Button();
            this.buttonB23 = new System.Windows.Forms.Button();
            this.buttonB14 = new System.Windows.Forms.Button();
            this.buttonB4 = new System.Windows.Forms.Button();
            this.panelSensors = new System.Windows.Forms.Panel();
            this.cbSensor16 = new System.Windows.Forms.CheckBox();
            this.cbSensor15 = new System.Windows.Forms.CheckBox();
            this.cbSensor14 = new System.Windows.Forms.CheckBox();
            this.cbSensor13 = new System.Windows.Forms.CheckBox();
            this.cbSensor12 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor11 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor10 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor9 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor8 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor7 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor6 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor4 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor5 = new System.Windows.Forms.CheckBox();
            this.checkBoxSensor2 = new System.Windows.Forms.CheckBox();
            this.labelSensors = new System.Windows.Forms.Label();
            this.checkBoxSensor1 = new System.Windows.Forms.CheckBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.cbLine8 = new System.Windows.Forms.CheckBox();
            this.cbLine7 = new System.Windows.Forms.CheckBox();
            this.cbLine6 = new System.Windows.Forms.CheckBox();
            this.cbLine5 = new System.Windows.Forms.CheckBox();
            this.cbLine4 = new System.Windows.Forms.CheckBox();
            this.cbLine3 = new System.Windows.Forms.CheckBox();
            this.cbLine2 = new System.Windows.Forms.CheckBox();
            this.cbLine1 = new System.Windows.Forms.CheckBox();
            this.labelLines = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSensor19 = new System.Windows.Forms.CheckBox();
            this.cbSensor18 = new System.Windows.Forms.CheckBox();
            this.cbSensor17 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSensors.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTCP
            // 
            this.textBoxTCP.Location = new System.Drawing.Point(3, 65);
            this.textBoxTCP.Name = "textBoxTCP";
            this.textBoxTCP.Size = new System.Drawing.Size(57, 20);
            this.textBoxTCP.TabIndex = 1;
            // 
            // textBoxUDP
            // 
            this.textBoxUDP.Location = new System.Drawing.Point(3, 91);
            this.textBoxUDP.Name = "textBoxUDP";
            this.textBoxUDP.Size = new System.Drawing.Size(57, 20);
            this.textBoxUDP.TabIndex = 2;
            // 
            // labelTCP
            // 
            this.labelTCP.AutoSize = true;
            this.labelTCP.Location = new System.Drawing.Point(65, 68);
            this.labelTCP.Name = "labelTCP";
            this.labelTCP.Size = new System.Drawing.Size(88, 13);
            this.labelTCP.TabIndex = 3;
            this.labelTCP.Text = "Tcp для команд";
            // 
            // labelUDP
            // 
            this.labelUDP.AutoSize = true;
            this.labelUDP.Location = new System.Drawing.Point(65, 98);
            this.labelUDP.Name = "labelUDP";
            this.labelUDP.Size = new System.Drawing.Size(56, 13);
            this.labelUDP.TabIndex = 4;
            this.labelUDP.Text = "UDP порт";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxTcpUS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ipAddressARM);
            this.panel2.Controls.Add(this.labelIpAddress);
            this.panel2.Controls.Add(this.labelUDP);
            this.panel2.Controls.Add(this.ipAddressControl);
            this.panel2.Controls.Add(this.textBoxUDP);
            this.panel2.Controls.Add(this.labelNetwokSettings);
            this.panel2.Controls.Add(this.textBoxTCP);
            this.panel2.Controls.Add(this.labelTCP);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 186);
            this.panel2.TabIndex = 5;
            // 
            // textBoxTcpUS
            // 
            this.textBoxTcpUS.Location = new System.Drawing.Point(3, 159);
            this.textBoxTcpUS.Name = "textBoxTcpUS";
            this.textBoxTcpUS.Size = new System.Drawing.Size(57, 20);
            this.textBoxTcpUS.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tcp для НС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP адрес АРМ";
            // 
            // ipAddressARM
            // 
            this.ipAddressARM.AllowInternalTab = false;
            this.ipAddressARM.AutoHeight = true;
            this.ipAddressARM.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressARM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressARM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressARM.Location = new System.Drawing.Point(3, 135);
            this.ipAddressARM.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressARM.Name = "ipAddressARM";
            this.ipAddressARM.ReadOnly = false;
            this.ipAddressARM.Size = new System.Drawing.Size(150, 20);
            this.ipAddressARM.TabIndex = 5;
            this.ipAddressARM.Text = "...";
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Location = new System.Drawing.Point(4, 24);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(69, 13);
            this.labelIpAddress.TabIndex = 4;
            this.labelIpAddress.Text = "IP адрес УУ";
            // 
            // ipAddressControl
            // 
            this.ipAddressControl.AllowInternalTab = false;
            this.ipAddressControl.AutoHeight = true;
            this.ipAddressControl.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl.Location = new System.Drawing.Point(3, 40);
            this.ipAddressControl.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl.Name = "ipAddressControl";
            this.ipAddressControl.ReadOnly = false;
            this.ipAddressControl.Size = new System.Drawing.Size(150, 20);
            this.ipAddressControl.TabIndex = 1;
            this.ipAddressControl.Text = "...";
            // 
            // labelNetwokSettings
            // 
            this.labelNetwokSettings.AutoSize = true;
            this.labelNetwokSettings.Location = new System.Drawing.Point(10, 6);
            this.labelNetwokSettings.Name = "labelNetwokSettings";
            this.labelNetwokSettings.Size = new System.Drawing.Size(133, 13);
            this.labelNetwokSettings.TabIndex = 0;
            this.labelNetwokSettings.Text = "Сетевые настройки АРМ";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(3, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 23);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Подключиться к сети";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(3, 32);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(150, 23);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Отключиться";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonConnect);
            this.panel3.Controls.Add(this.buttonDisconnect);
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 60);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkBoxB3Auto);
            this.panel4.Controls.Add(this.buyttonB3);
            this.panel4.Location = new System.Drawing.Point(3, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 64);
            this.panel4.TabIndex = 9;
            // 
            // checkBoxB3Auto
            // 
            this.checkBoxB3Auto.AutoSize = true;
            this.checkBoxB3Auto.Location = new System.Drawing.Point(28, 5);
            this.checkBoxB3Auto.Name = "checkBoxB3Auto";
            this.checkBoxB3Auto.Size = new System.Drawing.Size(102, 17);
            this.checkBoxB3Auto.TabIndex = 5;
            this.checkBoxB3Auto.Text = "Б3 - авто ответ";
            this.checkBoxB3Auto.UseVisualStyleBackColor = true;
            // 
            // buyttonB3
            // 
            this.buyttonB3.Location = new System.Drawing.Point(4, 28);
            this.buyttonB3.Name = "buyttonB3";
            this.buyttonB3.Size = new System.Drawing.Size(149, 23);
            this.buyttonB3.TabIndex = 4;
            this.buyttonB3.Text = "Б3: Отправить АП";
            this.buyttonB3.UseVisualStyleBackColor = true;
            this.buyttonB3.Click += new System.EventHandler(this.buyttonB3_Click);
            // 
            // buttonB23
            // 
            this.buttonB23.Location = new System.Drawing.Point(4, 32);
            this.buttonB23.Name = "buttonB23";
            this.buttonB23.Size = new System.Drawing.Size(149, 23);
            this.buttonB23.TabIndex = 2;
            this.buttonB23.Text = "Б23: НС состояния";
            this.buttonB23.UseVisualStyleBackColor = true;
            this.buttonB23.Click += new System.EventHandler(this.buttonB23_Click);
            // 
            // buttonB14
            // 
            this.buttonB14.Location = new System.Drawing.Point(7, 3);
            this.buttonB14.Name = "buttonB14";
            this.buttonB14.Size = new System.Drawing.Size(147, 23);
            this.buttonB14.TabIndex = 1;
            this.buttonB14.Text = "Б14: Состояние";
            this.buttonB14.UseVisualStyleBackColor = true;
            this.buttonB14.Click += new System.EventHandler(this.buttonB14_Click);
            // 
            // buttonB4
            // 
            this.buttonB4.Location = new System.Drawing.Point(5, 3);
            this.buttonB4.Name = "buttonB4";
            this.buttonB4.Size = new System.Drawing.Size(149, 23);
            this.buttonB4.TabIndex = 0;
            this.buttonB4.Text = "Б4: Подтверждение ОУ";
            this.buttonB4.UseVisualStyleBackColor = true;
            this.buttonB4.Click += new System.EventHandler(this.buttonB4_Click);
            // 
            // panelSensors
            // 
            this.panelSensors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSensors.Controls.Add(this.cbSensor16);
            this.panelSensors.Controls.Add(this.cbSensor15);
            this.panelSensors.Controls.Add(this.cbSensor14);
            this.panelSensors.Controls.Add(this.cbSensor13);
            this.panelSensors.Controls.Add(this.cbSensor12);
            this.panelSensors.Controls.Add(this.checkBoxSensor11);
            this.panelSensors.Controls.Add(this.checkBoxSensor10);
            this.panelSensors.Controls.Add(this.checkBoxSensor9);
            this.panelSensors.Controls.Add(this.checkBoxSensor8);
            this.panelSensors.Controls.Add(this.checkBoxSensor7);
            this.panelSensors.Controls.Add(this.checkBoxSensor6);
            this.panelSensors.Controls.Add(this.checkBoxSensor4);
            this.panelSensors.Controls.Add(this.checkBoxSensor3);
            this.panelSensors.Controls.Add(this.checkBoxSensor5);
            this.panelSensors.Controls.Add(this.checkBoxSensor2);
            this.panelSensors.Controls.Add(this.labelSensors);
            this.panelSensors.Controls.Add(this.checkBoxSensor1);
            this.panelSensors.Location = new System.Drawing.Point(165, 12);
            this.panelSensors.Name = "panelSensors";
            this.panelSensors.Size = new System.Drawing.Size(308, 399);
            this.panelSensors.TabIndex = 10;
            // 
            // cbSensor16
            // 
            this.cbSensor16.AutoSize = true;
            this.cbSensor16.Location = new System.Drawing.Point(10, 371);
            this.cbSensor16.Name = "cbSensor16";
            this.cbSensor16.Size = new System.Drawing.Size(272, 17);
            this.cbSensor16.TabIndex = 15;
            this.cbSensor16.Text = "Переход в дежурный режим по сбою при работе";
            this.cbSensor16.UseVisualStyleBackColor = true;
            this.cbSensor16.CheckedChanged += new System.EventHandler(this.cbSensor16_CheckedChanged);
            // 
            // cbSensor15
            // 
            this.cbSensor15.AutoSize = true;
            this.cbSensor15.Location = new System.Drawing.Point(10, 348);
            this.cbSensor15.Name = "cbSensor15";
            this.cbSensor15.Size = new System.Drawing.Size(273, 17);
            this.cbSensor15.TabIndex = 14;
            this.cbSensor15.Text = "Переход в дежурный режим по таймауту работы";
            this.cbSensor15.UseVisualStyleBackColor = true;
            this.cbSensor15.CheckedChanged += new System.EventHandler(this.cbSensor15_CheckedChanged);
            // 
            // cbSensor14
            // 
            this.cbSensor14.AutoSize = true;
            this.cbSensor14.Location = new System.Drawing.Point(10, 325);
            this.cbSensor14.Name = "cbSensor14";
            this.cbSensor14.Size = new System.Drawing.Size(140, 17);
            this.cbSensor14.TabIndex = 13;
            this.cbSensor14.Text = "Запуск в режиме речи";
            this.cbSensor14.UseVisualStyleBackColor = true;
            this.cbSensor14.CheckedChanged += new System.EventHandler(this.cbSensor14_CheckedChanged);
            // 
            // cbSensor13
            // 
            this.cbSensor13.AutoSize = true;
            this.cbSensor13.Location = new System.Drawing.Point(10, 302);
            this.cbSensor13.Name = "cbSensor13";
            this.cbSensor13.Size = new System.Drawing.Size(155, 17);
            this.cbSensor13.TabIndex = 12;
            this.cbSensor13.Text = "Запуск в режиме сирены";
            this.cbSensor13.UseVisualStyleBackColor = true;
            this.cbSensor13.CheckedChanged += new System.EventHandler(this.cbSensor13_CheckedChanged);
            // 
            // cbSensor12
            // 
            this.cbSensor12.AutoSize = true;
            this.cbSensor12.Location = new System.Drawing.Point(10, 279);
            this.cbSensor12.Name = "cbSensor12";
            this.cbSensor12.Size = new System.Drawing.Size(101, 17);
            this.cbSensor12.TabIndex = 11;
            this.cbSensor12.Text = "Включение УУ";
            this.cbSensor12.UseVisualStyleBackColor = true;
            this.cbSensor12.CheckedChanged += new System.EventHandler(this.cbSensor12_CheckedChanged);
            // 
            // checkBoxSensor11
            // 
            this.checkBoxSensor11.AutoSize = true;
            this.checkBoxSensor11.Location = new System.Drawing.Point(10, 250);
            this.checkBoxSensor11.Name = "checkBoxSensor11";
            this.checkBoxSensor11.Size = new System.Drawing.Size(185, 17);
            this.checkBoxSensor11.TabIndex = 10;
            this.checkBoxSensor11.Text = "Температура ниже допустимой";
            this.checkBoxSensor11.UseVisualStyleBackColor = true;
            this.checkBoxSensor11.CheckedChanged += new System.EventHandler(this.checkBoxSensor11_CheckedChanged);
            // 
            // checkBoxSensor10
            // 
            this.checkBoxSensor10.AutoSize = true;
            this.checkBoxSensor10.Location = new System.Drawing.Point(10, 227);
            this.checkBoxSensor10.Name = "checkBoxSensor10";
            this.checkBoxSensor10.Size = new System.Drawing.Size(187, 17);
            this.checkBoxSensor10.TabIndex = 9;
            this.checkBoxSensor10.Text = "Температура выше допустимой";
            this.checkBoxSensor10.UseVisualStyleBackColor = true;
            this.checkBoxSensor10.CheckedChanged += new System.EventHandler(this.checkBoxSensor10_CheckedChanged);
            // 
            // checkBoxSensor9
            // 
            this.checkBoxSensor9.AutoSize = true;
            this.checkBoxSensor9.Location = new System.Drawing.Point(10, 204);
            this.checkBoxSensor9.Name = "checkBoxSensor9";
            this.checkBoxSensor9.Size = new System.Drawing.Size(124, 17);
            this.checkBoxSensor9.TabIndex = 8;
            this.checkBoxSensor9.Text = "Неисправность ОУ";
            this.checkBoxSensor9.UseVisualStyleBackColor = true;
            this.checkBoxSensor9.CheckedChanged += new System.EventHandler(this.checkBoxSensor9_CheckedChanged);
            // 
            // checkBoxSensor8
            // 
            this.checkBoxSensor8.AutoSize = true;
            this.checkBoxSensor8.Location = new System.Drawing.Point(10, 181);
            this.checkBoxSensor8.Name = "checkBoxSensor8";
            this.checkBoxSensor8.Size = new System.Drawing.Size(152, 17);
            this.checkBoxSensor8.TabIndex = 7;
            this.checkBoxSensor8.Text = "Неисправность фидеров";
            this.checkBoxSensor8.UseVisualStyleBackColor = true;
            this.checkBoxSensor8.CheckedChanged += new System.EventHandler(this.checkBoxSensor8_CheckedChanged);
            // 
            // checkBoxSensor7
            // 
            this.checkBoxSensor7.AutoSize = true;
            this.checkBoxSensor7.Location = new System.Drawing.Point(10, 158);
            this.checkBoxSensor7.Name = "checkBoxSensor7";
            this.checkBoxSensor7.Size = new System.Drawing.Size(203, 17);
            this.checkBoxSensor7.TabIndex = 6;
            this.checkBoxSensor7.Text = "Неисправность устр. отображения";
            this.checkBoxSensor7.UseVisualStyleBackColor = true;
            this.checkBoxSensor7.CheckedChanged += new System.EventHandler(this.checkBoxSensor7_CheckedChanged);
            // 
            // checkBoxSensor6
            // 
            this.checkBoxSensor6.AutoSize = true;
            this.checkBoxSensor6.Location = new System.Drawing.Point(10, 135);
            this.checkBoxSensor6.Name = "checkBoxSensor6";
            this.checkBoxSensor6.Size = new System.Drawing.Size(154, 17);
            this.checkBoxSensor6.TabIndex = 5;
            this.checkBoxSensor6.Text = "Неиспраность усилителя";
            this.checkBoxSensor6.UseVisualStyleBackColor = true;
            this.checkBoxSensor6.CheckedChanged += new System.EventHandler(this.checkBoxSensor6_CheckedChanged);
            // 
            // checkBoxSensor4
            // 
            this.checkBoxSensor4.AutoSize = true;
            this.checkBoxSensor4.Location = new System.Drawing.Point(10, 89);
            this.checkBoxSensor4.Name = "checkBoxSensor4";
            this.checkBoxSensor4.Size = new System.Drawing.Size(121, 17);
            this.checkBoxSensor4.TabIndex = 4;
            this.checkBoxSensor4.Text = "Низкий заряд АКБ";
            this.checkBoxSensor4.UseVisualStyleBackColor = true;
            this.checkBoxSensor4.CheckedChanged += new System.EventHandler(this.checkBoxSensor4_CheckedChanged);
            // 
            // checkBoxSensor3
            // 
            this.checkBoxSensor3.AutoSize = true;
            this.checkBoxSensor3.Location = new System.Drawing.Point(10, 68);
            this.checkBoxSensor3.Name = "checkBoxSensor3";
            this.checkBoxSensor3.Size = new System.Drawing.Size(153, 17);
            this.checkBoxSensor3.TabIndex = 3;
            this.checkBoxSensor3.Text = "Отсутствует напряжение";
            this.checkBoxSensor3.UseVisualStyleBackColor = true;
            this.checkBoxSensor3.CheckedChanged += new System.EventHandler(this.checkBoxSensor3_CheckedChanged);
            // 
            // checkBoxSensor5
            // 
            this.checkBoxSensor5.AutoSize = true;
            this.checkBoxSensor5.Location = new System.Drawing.Point(10, 112);
            this.checkBoxSensor5.Name = "checkBoxSensor5";
            this.checkBoxSensor5.Size = new System.Drawing.Size(141, 17);
            this.checkBoxSensor5.TabIndex = 3;
            this.checkBoxSensor5.Text = "Перегрузка усилителя";
            this.checkBoxSensor5.UseVisualStyleBackColor = true;
            this.checkBoxSensor5.CheckedChanged += new System.EventHandler(this.checkBoxSensor5_CheckedChanged);
            // 
            // checkBoxSensor2
            // 
            this.checkBoxSensor2.AutoSize = true;
            this.checkBoxSensor2.Location = new System.Drawing.Point(10, 45);
            this.checkBoxSensor2.Name = "checkBoxSensor2";
            this.checkBoxSensor2.Size = new System.Drawing.Size(168, 17);
            this.checkBoxSensor2.TabIndex = 2;
            this.checkBoxSensor2.Text = "Санкционированный доступ";
            this.checkBoxSensor2.UseVisualStyleBackColor = true;
            this.checkBoxSensor2.CheckedChanged += new System.EventHandler(this.checkBoxSensor2_CheckedChanged);
            // 
            // labelSensors
            // 
            this.labelSensors.AutoSize = true;
            this.labelSensors.Location = new System.Drawing.Point(87, 6);
            this.labelSensors.Name = "labelSensors";
            this.labelSensors.Size = new System.Drawing.Size(50, 13);
            this.labelSensors.TabIndex = 1;
            this.labelSensors.Text = "Датчики";
            // 
            // checkBoxSensor1
            // 
            this.checkBoxSensor1.AutoSize = true;
            this.checkBoxSensor1.Location = new System.Drawing.Point(10, 22);
            this.checkBoxSensor1.Name = "checkBoxSensor1";
            this.checkBoxSensor1.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSensor1.TabIndex = 0;
            this.checkBoxSensor1.Text = "НСД";
            this.checkBoxSensor1.UseVisualStyleBackColor = true;
            this.checkBoxSensor1.CheckedChanged += new System.EventHandler(this.checkBoxSensor1_CheckedChanged);
            // 
            // panelLine
            // 
            this.panelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLine.Controls.Add(this.cbLine8);
            this.panelLine.Controls.Add(this.cbLine7);
            this.panelLine.Controls.Add(this.cbLine6);
            this.panelLine.Controls.Add(this.cbLine5);
            this.panelLine.Controls.Add(this.cbLine4);
            this.panelLine.Controls.Add(this.cbLine3);
            this.panelLine.Controls.Add(this.cbLine2);
            this.panelLine.Controls.Add(this.cbLine1);
            this.panelLine.Controls.Add(this.labelLines);
            this.panelLine.Location = new System.Drawing.Point(166, 423);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(304, 50);
            this.panelLine.TabIndex = 11;
            // 
            // cbLine8
            // 
            this.cbLine8.AutoSize = true;
            this.cbLine8.Location = new System.Drawing.Point(263, 25);
            this.cbLine8.Name = "cbLine8";
            this.cbLine8.Size = new System.Drawing.Size(32, 17);
            this.cbLine8.TabIndex = 8;
            this.cbLine8.Text = "8";
            this.cbLine8.UseVisualStyleBackColor = true;
            this.cbLine8.CheckedChanged += new System.EventHandler(this.cbLine8_CheckedChanged);
            // 
            // cbLine7
            // 
            this.cbLine7.AutoSize = true;
            this.cbLine7.Location = new System.Drawing.Point(226, 25);
            this.cbLine7.Name = "cbLine7";
            this.cbLine7.Size = new System.Drawing.Size(32, 17);
            this.cbLine7.TabIndex = 7;
            this.cbLine7.Text = "7";
            this.cbLine7.UseVisualStyleBackColor = true;
            this.cbLine7.CheckedChanged += new System.EventHandler(this.cbLine7_CheckedChanged);
            // 
            // cbLine6
            // 
            this.cbLine6.AutoSize = true;
            this.cbLine6.Location = new System.Drawing.Point(188, 25);
            this.cbLine6.Name = "cbLine6";
            this.cbLine6.Size = new System.Drawing.Size(32, 17);
            this.cbLine6.TabIndex = 6;
            this.cbLine6.Text = "6";
            this.cbLine6.UseVisualStyleBackColor = true;
            this.cbLine6.CheckedChanged += new System.EventHandler(this.cbLine6_CheckedChanged);
            // 
            // cbLine5
            // 
            this.cbLine5.AutoSize = true;
            this.cbLine5.Location = new System.Drawing.Point(150, 25);
            this.cbLine5.Name = "cbLine5";
            this.cbLine5.Size = new System.Drawing.Size(32, 17);
            this.cbLine5.TabIndex = 5;
            this.cbLine5.Text = "5";
            this.cbLine5.UseVisualStyleBackColor = true;
            this.cbLine5.CheckedChanged += new System.EventHandler(this.cbLine5_CheckedChanged);
            // 
            // cbLine4
            // 
            this.cbLine4.AutoSize = true;
            this.cbLine4.Location = new System.Drawing.Point(118, 25);
            this.cbLine4.Name = "cbLine4";
            this.cbLine4.Size = new System.Drawing.Size(32, 17);
            this.cbLine4.TabIndex = 4;
            this.cbLine4.Text = "4";
            this.cbLine4.UseVisualStyleBackColor = true;
            this.cbLine4.CheckedChanged += new System.EventHandler(this.cbLine4_CheckedChanged);
            // 
            // cbLine3
            // 
            this.cbLine3.AutoSize = true;
            this.cbLine3.Location = new System.Drawing.Point(81, 25);
            this.cbLine3.Name = "cbLine3";
            this.cbLine3.Size = new System.Drawing.Size(32, 17);
            this.cbLine3.TabIndex = 3;
            this.cbLine3.Text = "3";
            this.cbLine3.UseVisualStyleBackColor = true;
            this.cbLine3.CheckedChanged += new System.EventHandler(this.cbLine3_CheckedChanged);
            // 
            // cbLine2
            // 
            this.cbLine2.AutoSize = true;
            this.cbLine2.Location = new System.Drawing.Point(43, 25);
            this.cbLine2.Name = "cbLine2";
            this.cbLine2.Size = new System.Drawing.Size(32, 17);
            this.cbLine2.TabIndex = 2;
            this.cbLine2.Text = "2";
            this.cbLine2.UseVisualStyleBackColor = true;
            this.cbLine2.CheckedChanged += new System.EventHandler(this.cbLine2_CheckedChanged);
            // 
            // cbLine1
            // 
            this.cbLine1.AutoSize = true;
            this.cbLine1.Location = new System.Drawing.Point(5, 25);
            this.cbLine1.Name = "cbLine1";
            this.cbLine1.Size = new System.Drawing.Size(32, 17);
            this.cbLine1.TabIndex = 1;
            this.cbLine1.Text = "1";
            this.cbLine1.UseVisualStyleBackColor = true;
            this.cbLine1.CheckedChanged += new System.EventHandler(this.cbLine1_CheckedChanged);
            // 
            // labelLines
            // 
            this.labelLines.AutoSize = true;
            this.labelLines.Location = new System.Drawing.Point(13, 6);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(193, 13);
            this.labelLines.TabIndex = 0;
            this.labelLines.Text = "Линии - указать наличие связи с ОУ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panelSensors);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 515);
            this.panel1.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.buttonB14);
            this.panel8.Controls.Add(this.buttonB23);
            this.panel8.Location = new System.Drawing.Point(3, 452);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(157, 59);
            this.panel8.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbSensor19);
            this.panel6.Controls.Add(this.cbSensor18);
            this.panel6.Controls.Add(this.buttonB4);
            this.panel6.Controls.Add(this.cbSensor17);
            this.panel6.Location = new System.Drawing.Point(3, 338);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 108);
            this.panel6.TabIndex = 15;
            // 
            // cbSensor19
            // 
            this.cbSensor19.AutoSize = true;
            this.cbSensor19.Location = new System.Drawing.Point(4, 84);
            this.cbSensor19.Name = "cbSensor19";
            this.cbSensor19.Size = new System.Drawing.Size(137, 17);
            this.cbSensor19.TabIndex = 18;
            this.cbSensor19.Text = "Оповещение успешно";
            this.cbSensor19.UseVisualStyleBackColor = true;
            this.cbSensor19.CheckedChanged += new System.EventHandler(this.cbSensor19_CheckedChanged);
            // 
            // cbSensor18
            // 
            this.cbSensor18.AutoSize = true;
            this.cbSensor18.Location = new System.Drawing.Point(4, 55);
            this.cbSensor18.Name = "cbSensor18";
            this.cbSensor18.Size = new System.Drawing.Size(129, 17);
            this.cbSensor18.TabIndex = 17;
            this.cbSensor18.Text = "Другое оповещении";
            this.cbSensor18.UseVisualStyleBackColor = true;
            this.cbSensor18.CheckedChanged += new System.EventHandler(this.cbSensor18_CheckedChanged);
            // 
            // cbSensor17
            // 
            this.cbSensor17.AutoSize = true;
            this.cbSensor17.Location = new System.Drawing.Point(4, 32);
            this.cbSensor17.Name = "cbSensor17";
            this.cbSensor17.Size = new System.Drawing.Size(84, 17);
            this.cbSensor17.TabIndex = 16;
            this.cbSensor17.Text = "Нет сеанса";
            this.cbSensor17.UseVisualStyleBackColor = true;
            this.cbSensor17.CheckedChanged += new System.EventHandler(this.cbSensor17_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonLogClear);
            this.panel7.Location = new System.Drawing.Point(165, 483);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 27);
            this.panel7.TabIndex = 14;
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.Location = new System.Drawing.Point(79, 1);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(134, 23);
            this.buttonLogClear.TabIndex = 0;
            this.buttonLogClear.Text = "Очистить лог";
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(476, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(648, 515);
            this.panel5.TabIndex = 14;
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.TextMessage});
            this.dataGridViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.Size = new System.Drawing.Size(648, 515);
            this.dataGridViewLog.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.FillWeight = 60.9137F;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            // 
            // TextMessage
            // 
            this.TextMessage.FillWeight = 139.0863F;
            this.TextMessage.HeaderText = "Текст сообщения";
            this.TextMessage.Name = "TextMessage";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 515);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Эмулятор УУ версия протокола 1.7";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelSensors.ResumeLayout(false);
            this.panelSensors.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        private void CheckBoxB3Auto_CheckedChanged(object sender, System.EventArgs e)
        {            
            if (checkBoxB3Auto.Checked == true)
                buyttonB3.Enabled = false;
            else 
                buyttonB3.Enabled = true;
            B3Change?.Invoke(this, checkBoxB3Auto.Checked);
        }

        private void NumericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 0) e.Handled = true;
        }

        private void NumericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue <= 256) e.Handled = true;
        }

        
        #endregion
        private System.Windows.Forms.TextBox textBoxTCP;
        private System.Windows.Forms.TextBox textBoxUDP;
        private System.Windows.Forms.Label labelTCP;
        private System.Windows.Forms.Label labelUDP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNetwokSettings;
        private System.Windows.Forms.Label labelIpAddress;
        private IPAddressControlLib.IPAddressControl ipAddressControl;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonB23;
        private System.Windows.Forms.Button buttonB14;
        private System.Windows.Forms.Button buttonB4;
        private System.Windows.Forms.Button buyttonB3;
        private Panel panelSensors;
        private CheckBox checkBoxSensor11;
        private CheckBox checkBoxSensor10;
        private CheckBox checkBoxSensor9;
        private CheckBox checkBoxSensor8;
        private CheckBox checkBoxSensor7;
        private CheckBox checkBoxSensor6;
        private CheckBox checkBoxSensor4;
        private CheckBox checkBoxSensor3;
        private CheckBox checkBoxSensor5;
        private CheckBox checkBoxSensor2;
        private Label labelSensors;
        private CheckBox checkBoxSensor1;
        private Panel panelLine;
        private Label labelLines;
        private Panel panel1;
        private Panel panel5;
        private DataGridView dataGridViewLog;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn TextMessage;
        private CheckBox checkBoxB3Auto;
        private TextBox textBoxTcpUS;
        private Label label3;
        private Label label2;
        private IPAddressControlLib.IPAddressControl ipAddressARM;
        private Panel panel7;
        private Button buttonLogClear;
        private CheckBox cbSensor16;
        private CheckBox cbSensor15;
        private CheckBox cbSensor14;
        private CheckBox cbSensor13;
        private CheckBox cbSensor12;
        private CheckBox cbLine8;
        private CheckBox cbLine7;
        private CheckBox cbLine6;
        private CheckBox cbLine5;
        private CheckBox cbLine4;
        private CheckBox cbLine3;
        private CheckBox cbLine2;
        private CheckBox cbLine1;
        private Panel panel6;
        private CheckBox cbSensor18;
        private CheckBox cbSensor17;
        private Panel panel8;
        private CheckBox cbSensor19;
    }
}

