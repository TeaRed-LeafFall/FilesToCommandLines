namespace FilesToCommandLines;

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
        components = new System.ComponentModel.Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        openFolder = new Button();
        updateList = new Button();
        generateText = new Button();
        searchBox = new TextBox();
        templateBox = new TextBox();
        pathLabel = new Label();
        filesListBox = new CheckedListBox();
        contextMenuStrip = new ContextMenuStrip(components);
        全选ToolStripMenuItem = new ToolStripMenuItem();
        全不选ToolStripMenuItem = new ToolStripMenuItem();
        反选ToolStripMenuItem = new ToolStripMenuItem();
        folderBrowserDialog = new FolderBrowserDialog();
        toolTip1 = new ToolTip(components);
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        contextMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(filesListBox, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.Size = new Size(446, 469);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.Controls.Add(openFolder, 1, 0);
        tableLayoutPanel2.Controls.Add(updateList, 1, 1);
        tableLayoutPanel2.Controls.Add(generateText, 1, 2);
        tableLayoutPanel2.Controls.Add(searchBox, 0, 1);
        tableLayoutPanel2.Controls.Add(templateBox, 0, 2);
        tableLayoutPanel2.Controls.Add(pathLabel, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(4, 3);
        tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.Size = new Size(438, 87);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // openFolder
        // 
        openFolder.Dock = DockStyle.Fill;
        openFolder.Location = new Point(354, 3);
        openFolder.Margin = new Padding(4, 3, 4, 3);
        openFolder.Name = "openFolder";
        openFolder.Size = new Size(80, 23);
        openFolder.TabIndex = 0;
        openFolder.Text = "打开目录";
        openFolder.UseVisualStyleBackColor = true;
        openFolder.Click += openFolder_Click;
        // 
        // updateList
        // 
        updateList.Dock = DockStyle.Fill;
        updateList.Location = new Point(353, 32);
        updateList.Name = "updateList";
        updateList.Size = new Size(82, 23);
        updateList.TabIndex = 1;
        updateList.Text = "刷新列表";
        updateList.UseVisualStyleBackColor = true;
        updateList.Click += updateList_Click;
        // 
        // generateText
        // 
        generateText.Dock = DockStyle.Fill;
        generateText.Location = new Point(353, 61);
        generateText.Name = "generateText";
        generateText.Size = new Size(82, 23);
        generateText.TabIndex = 2;
        generateText.Text = "生成文本";
        generateText.UseVisualStyleBackColor = true;
        generateText.Click += generateText_Click;
        // 
        // searchBox
        // 
        searchBox.Dock = DockStyle.Fill;
        searchBox.Location = new Point(3, 32);
        searchBox.Name = "searchBox";
        searchBox.PlaceholderText = "填写比如 *.png 样式的文本 支持?和*占位符";
        searchBox.Size = new Size(344, 25);
        searchBox.TabIndex = 3;
        toolTip1.SetToolTip(searchBox, "可以使用 搜索功能过滤文件");
        // 
        // templateBox
        // 
        templateBox.Dock = DockStyle.Fill;
        templateBox.Location = new Point(3, 61);
        templateBox.Name = "templateBox";
        templateBox.PlaceholderText = "模板 类似 xx  %F  可以用%N仅获取没有扩展名的文件名";
        templateBox.Size = new Size(344, 25);
        templateBox.TabIndex = 4;
        toolTip1.SetToolTip(templateBox, "例如 ffmpeg -i %F %N.wav \r\n%F 文件的完整路径包含文件名及扩展名\r\n%N 只有文件名，没有扩展名和路径\r\n请需要你在想要保存的路径执行\r\n建议%F两侧加上双引号以免具有特殊问题");
        // 
        // pathLabel
        // 
        pathLabel.AutoSize = true;
        pathLabel.Dock = DockStyle.Fill;
        pathLabel.Location = new Point(3, 0);
        pathLabel.Name = "pathLabel";
        pathLabel.Size = new Size(344, 29);
        pathLabel.TabIndex = 5;
        pathLabel.Text = "请选择一个目录";
        pathLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // filesListBox
        // 
        filesListBox.BorderStyle = BorderStyle.None;
        filesListBox.CheckOnClick = true;
        filesListBox.ContextMenuStrip = contextMenuStrip;
        filesListBox.Dock = DockStyle.Fill;
        filesListBox.FormattingEnabled = true;
        filesListBox.Location = new Point(3, 96);
        filesListBox.Name = "filesListBox";
        filesListBox.Size = new Size(440, 370);
        filesListBox.TabIndex = 1;
        toolTip1.SetToolTip(filesListBox, "这里是选中文件夹的文件列表，右键可以打开选择菜单。\r\n请注意这里不包含子文件夹的文件，只有这一层的！");
        // 
        // contextMenuStrip
        // 
        contextMenuStrip.Items.AddRange(new ToolStripItem[] { 全选ToolStripMenuItem, 全不选ToolStripMenuItem, 反选ToolStripMenuItem });
        contextMenuStrip.Name = "contextMenuStrip";
        contextMenuStrip.Size = new Size(118, 76);
        contextMenuStrip.Text = "对 文件列表 进行选择操作";
        // 
        // 全选ToolStripMenuItem
        // 
        全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
        全选ToolStripMenuItem.Size = new Size(117, 24);
        全选ToolStripMenuItem.Text = "全选";
        全选ToolStripMenuItem.Click += 全选ToolStripMenuItem_Click;
        // 
        // 全不选ToolStripMenuItem
        // 
        全不选ToolStripMenuItem.Name = "全不选ToolStripMenuItem";
        全不选ToolStripMenuItem.Size = new Size(117, 24);
        全不选ToolStripMenuItem.Text = "全不选";
        全不选ToolStripMenuItem.Click += 全不选ToolStripMenuItem_Click;
        // 
        // 反选ToolStripMenuItem
        // 
        反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
        反选ToolStripMenuItem.Size = new Size(117, 24);
        反选ToolStripMenuItem.Text = "反选";
        反选ToolStripMenuItem.Click += 反选ToolStripMenuItem_Click;
        // 
        // folderBrowserDialog
        // 
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        folderBrowserDialog.ShowNewFolderButton = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(446, 469);
        Controls.Add(tableLayoutPanel1);
        Font = new Font("Resource Han Rounded CN", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Margin = new Padding(4, 3, 4, 3);
        MinimumSize = new Size(462, 507);
        Name = "Form1";
        Text = "Files To CommandLines ";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        contextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button openFolder;
    private Button updateList;
    private Button generateText;
    private TextBox searchBox;
    private TextBox templateBox;
    private Label pathLabel;
    private CheckedListBox filesListBox;
    private FolderBrowserDialog folderBrowserDialog;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem 全选ToolStripMenuItem;
    private ToolStripMenuItem 反选ToolStripMenuItem;
    private ToolStripMenuItem 全不选ToolStripMenuItem;
    private ToolTip toolTip1;
}
