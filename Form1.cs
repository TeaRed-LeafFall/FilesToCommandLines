using System.Diagnostics;
using System.Text;

namespace FilesToCommandLines;

public partial class Form1 : Form
{
    string path = string.Empty;
    public Form1()
    {
        InitializeComponent();
    }

    private void openFolder_Click(object sender, EventArgs e)
    {
        folderBrowserDialog.ShowDialog();
        var path = folderBrowserDialog.SelectedPath;
        if (Path.Exists(path))
        {
            this.path = path;
            OnUpdatePath();
        }
    }
    private void OnUpdatePath()
    {
        pathLabel.Text = path;
        OnUpdateFiles();
    }
    private void OnUpdateFiles()
    {
        if (Path.Exists(path))
        {
            filesListBox.BeginUpdate();
            filesListBox.Items.Clear();
            var filePaths = Directory.GetFiles(path, searchBox.Text);
            List<string> fileNames = new();
            foreach (var filePath in filePaths)
            {
                fileNames.Add(Path.GetFileName(filePath));
            }
            filesListBox.Items.AddRange(fileNames.ToArray());
            filesListBox.EndUpdate();
        }
        else
        {
            MessageBox.Show("你似乎没有选择目录，或者目录现在不存在了！", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void updateList_Click(object sender, EventArgs e)
    {
        OnUpdateFiles();
    }

    private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        filesListBox.BeginUpdate();
        for (var i = 0; i < filesListBox.Items.Count; i++)
        {
            filesListBox.SetItemChecked(i, true);
        }
        filesListBox.EndUpdate();
    }

    private void 反选ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        filesListBox.BeginUpdate();
        for (var i = 0; i < filesListBox.Items.Count; i++)
        {
            filesListBox.SetItemChecked(i, filesListBox.GetItemChecked(i));
        }
        filesListBox.EndUpdate();
    }

    private void 全不选ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        filesListBox.BeginUpdate();
        for (var i = 0; i < filesListBox.Items.Count; i++)
        {
            filesListBox.SetItemChecked(i, false);
        }
        filesListBox.EndUpdate();
    }

    private void generateText_Click(object sender, EventArgs e)
    {

        if (filesListBox.CheckedItems.Count <= 0)
        {
            MessageBox.Show("哎哎哎！你似乎还没有选择文件呢，注意在文件列表右键可以全选哦！", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show("我们现在开始吗？" + Environment.NewLine +
                            "本程序使用并行处理字符串，速度应该会非常迅速！ヾ(^▽^*)))" + Environment.NewLine +
                            "在进行过程中的时候请不要误认为程序卡死哦！w(ﾟДﾟ)w", ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
        {
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        this.Enabled = false;

        if (!(templateBox.Text.Contains("%F") || templateBox.Text.Contains("%N")))
        {
            MessageBox.Show("模板必须包含%F或者%N占位符！ヾ(≧へ≦)〃", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            return;
        }

        // 声明一个列表来保存拼接后的文件路径
        List<string> filePathList = new List<string>();

        // 使用并行处理来拼接文件名和路径
        Parallel.ForEach(filesListBox.CheckedItems.Cast<object>(), (item) =>
        {
            // 这里需要将item转换成字符串，并拼接路径
            var filePath = Path.Combine(path, item.ToString());

            // 然后将拼接后的路径添加到列表中
            lock (filePathList)
            {
                filePathList.Add(filePath);
            }
        });

        StringBuilder sb = new StringBuilder();
        var template = templateBox.Text;

        // 使用并行处理来替换模板中的占位符，并添加到StringBuilder中
        Parallel.ForEach(filePathList, (filePath) =>
        {
            var replacedTemplate = template.Replace("%N", Path.GetFileNameWithoutExtension(filePath)).Replace("%F", filePath);
            lock (sb)
            {
                sb.AppendLine(replacedTemplate);
            }
        });

        // 将StringBuilder的内容赋值给result变量
        var result = sb.ToString();

        this.Enabled = true;
        this.Cursor = Cursors.Default;

        MessageBox.Show("生成完成！q(≧▽≦q)", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        if (!string.IsNullOrWhiteSpace(result))
        {
            Clipboard.SetText(result);
            MessageBox.Show("已将结果复制到剪贴板！(/≧▽≦)/", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        if (MessageBox.Show("是否将结果保存到一个文件中? ヾ(•ω•`)o", ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件 (*.txt)|*.txt|批处理文件 (*.bat)|*.bat|所有文件 (*.*)|*.*";
            saveFileDialog.FileName = "Result.txt"; // 默认文件名
            saveFileDialog.Title = "保存结果";
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                if (Path.GetExtension(filePath) == ".bat") {
                    MessageBox.Show("温馨提醒：请注意批处理文件的编码问题哦！记得自己转换哦！", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                File.WriteAllText(filePath, result);
            }
        }

        
    }

}
