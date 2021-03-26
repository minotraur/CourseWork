namespace ParcerForJobSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ParcerBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.FeedBackBtn = new System.Windows.Forms.Button();
            this.RedPanel = new System.Windows.Forms.Panel();
            this.DescriptionBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SlideAnimator = new AnimatorNS.Animator(this.components);
            this.desc1 = new ParcerForJobSearch.desc();
            this.LogoAnimator = new AnimatorNS.Animator(this.components);
            this.pars1 = new ParcerForJobSearch.pars();
            this.helping1 = new ParcerForJobSearch.helping();
            this.abouting1 = new ParcerForJobSearch.abouting();
            this.feedbacking1 = new ParcerForJobSearch.feedbacking();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ParcerBtn);
            this.panel1.Controls.Add(this.HelpBtn);
            this.panel1.Controls.Add(this.AboutBtn);
            this.panel1.Controls.Add(this.FeedBackBtn);
            this.panel1.Controls.Add(this.RedPanel);
            this.panel1.Controls.Add(this.DescriptionBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.LogoAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 678);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.pictureBox3, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox3, AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ParcerBtn
            // 
            this.ParcerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ParcerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.ParcerBtn, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ParcerBtn, AnimatorNS.DecorationType.None);
            this.ParcerBtn.FlatAppearance.BorderSize = 0;
            this.ParcerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParcerBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParcerBtn.ForeColor = System.Drawing.Color.White;
            this.ParcerBtn.Image = ((System.Drawing.Image)(resources.GetObject("ParcerBtn.Image")));
            this.ParcerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParcerBtn.Location = new System.Drawing.Point(8, 286);
            this.ParcerBtn.Name = "ParcerBtn";
            this.ParcerBtn.Size = new System.Drawing.Size(245, 44);
            this.ParcerBtn.TabIndex = 3;
            this.ParcerBtn.Text = "Парсер";
            this.ParcerBtn.UseVisualStyleBackColor = false;
            this.ParcerBtn.Click += new System.EventHandler(this.ParcerBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.HelpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.HelpBtn, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.HelpBtn, AnimatorNS.DecorationType.None);
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBtn.Location = new System.Drawing.Point(8, 361);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(245, 44);
            this.HelpBtn.TabIndex = 4;
            this.HelpBtn.Text = "Помощь";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.AboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.AboutBtn, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.AboutBtn, AnimatorNS.DecorationType.None);
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("AboutBtn.Image")));
            this.AboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.Location = new System.Drawing.Point(8, 436);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(245, 44);
            this.AboutBtn.TabIndex = 5;
            this.AboutBtn.Text = "О программе";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // FeedBackBtn
            // 
            this.FeedBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FeedBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.FeedBackBtn, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.FeedBackBtn, AnimatorNS.DecorationType.None);
            this.FeedBackBtn.FlatAppearance.BorderSize = 0;
            this.FeedBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedBackBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeedBackBtn.ForeColor = System.Drawing.Color.White;
            this.FeedBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("FeedBackBtn.Image")));
            this.FeedBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FeedBackBtn.Location = new System.Drawing.Point(8, 511);
            this.FeedBackBtn.Name = "FeedBackBtn";
            this.FeedBackBtn.Size = new System.Drawing.Size(245, 44);
            this.FeedBackBtn.TabIndex = 6;
            this.FeedBackBtn.Text = "   Обратная связь";
            this.FeedBackBtn.UseVisualStyleBackColor = false;
            this.FeedBackBtn.Click += new System.EventHandler(this.FeedBackBtn_Click);
            // 
            // RedPanel
            // 
            this.RedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.LogoAnimator.SetDecoration(this.RedPanel, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.RedPanel, AnimatorNS.DecorationType.None);
            this.RedPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.RedPanel.Location = new System.Drawing.Point(0, 211);
            this.RedPanel.Name = "RedPanel";
            this.RedPanel.Size = new System.Drawing.Size(8, 44);
            this.RedPanel.TabIndex = 7;
            // 
            // DescriptionBtn
            // 
            this.DescriptionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.DescriptionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideAnimator.SetDecoration(this.DescriptionBtn, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.DescriptionBtn, AnimatorNS.DecorationType.None);
            this.DescriptionBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBtn.ForeColor = System.Drawing.Color.White;
            this.DescriptionBtn.Image = ((System.Drawing.Image)(resources.GetObject("DescriptionBtn.Image")));
            this.DescriptionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescriptionBtn.Location = new System.Drawing.Point(7, 211);
            this.DescriptionBtn.Name = "DescriptionBtn";
            this.DescriptionBtn.Size = new System.Drawing.Size(246, 44);
            this.DescriptionBtn.TabIndex = 2;
            this.DescriptionBtn.Text = "Описание";
            this.DescriptionBtn.UseVisualStyleBackColor = false;
            this.DescriptionBtn.Click += new System.EventHandler(this.DescriptionBtn_Click);
            // 
            // pictureBox1
            // 
            this.SlideAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.gunaControlBox3);
            this.header.Controls.Add(this.gunaControlBox1);
            this.header.Controls.Add(this.gunaControlBox2);
            this.LogoAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1100, 22);
            this.header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.SlideAnimator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parser for work search";
            // 
            // pictureBox2
            // 
            this.SlideAnimator.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 22);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.LogoAnimator.SetDecoration(this.gunaControlBox3, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.gunaControlBox3, AnimatorNS.DecorationType.None);
            this.gunaControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(1011, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(30, 22);
            this.gunaControlBox3.TabIndex = 4;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.LogoAnimator.SetDecoration(this.gunaControlBox1, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.gunaControlBox1, AnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1070, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 22);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.LogoAnimator.SetDecoration(this.gunaControlBox2, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this.gunaControlBox2, AnimatorNS.DecorationType.None);
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1041, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(30, 22);
            this.gunaControlBox2.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SlideAnimator
            // 
            this.SlideAnimator.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.SlideAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.SlideAnimator.DefaultAnimation = animation1;
            // 
            // desc1
            // 
            this.desc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SlideAnimator.SetDecoration(this.desc1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.desc1, AnimatorNS.DecorationType.None);
            this.desc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desc1.Location = new System.Drawing.Point(253, 22);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(847, 678);
            this.desc1.TabIndex = 2;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.LogoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.LogoAnimator.DefaultAnimation = animation2;
            this.LogoAnimator.MaxAnimationTime = 500;
            // 
            // pars1
            // 
            this.pars1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SlideAnimator.SetDecoration(this.pars1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pars1, AnimatorNS.DecorationType.None);
            this.pars1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pars1.Location = new System.Drawing.Point(253, 22);
            this.pars1.Name = "pars1";
            this.pars1.Size = new System.Drawing.Size(847, 678);
            this.pars1.TabIndex = 3;
            // 
            // helping1
            // 
            this.helping1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SlideAnimator.SetDecoration(this.helping1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.helping1, AnimatorNS.DecorationType.None);
            this.helping1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helping1.Location = new System.Drawing.Point(253, 22);
            this.helping1.Name = "helping1";
            this.helping1.Size = new System.Drawing.Size(847, 678);
            this.helping1.TabIndex = 4;
            // 
            // abouting1
            // 
            this.abouting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SlideAnimator.SetDecoration(this.abouting1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.abouting1, AnimatorNS.DecorationType.None);
            this.abouting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abouting1.Location = new System.Drawing.Point(253, 22);
            this.abouting1.Name = "abouting1";
            this.abouting1.Size = new System.Drawing.Size(847, 678);
            this.abouting1.TabIndex = 5;
            // 
            // feedbacking1
            // 
            this.feedbacking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.SlideAnimator.SetDecoration(this.feedbacking1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.feedbacking1, AnimatorNS.DecorationType.None);
            this.feedbacking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbacking1.Location = new System.Drawing.Point(253, 22);
            this.feedbacking1.Name = "feedbacking1";
            this.feedbacking1.Size = new System.Drawing.Size(847, 678);
            this.feedbacking1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.feedbacking1);
            this.Controls.Add(this.abouting1);
            this.Controls.Add(this.helping1);
            this.Controls.Add(this.pars1);
            this.Controls.Add(this.desc1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.LogoAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.SlideAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel header;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DescriptionBtn;
        private System.Windows.Forms.Button ParcerBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button FeedBackBtn;
        private System.Windows.Forms.Panel RedPanel;
        private desc desc1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private AnimatorNS.Animator SlideAnimator;
        private AnimatorNS.Animator LogoAnimator;
        private System.Windows.Forms.PictureBox pictureBox3;
        private pars pars1;
        private helping helping1;
        private abouting abouting1;
        private feedbacking feedbacking1;
    }
}

