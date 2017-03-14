using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件分类存储_控制台
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            Console.WriteLine("功能：整理当前文件夹内所有文件。将同类型的文件移动到同目录下");
            Console.WriteLine("[  Y-继续；任意键退出  ]");
            string flag = Console.ReadLine();
            if (flag == "Y" || flag == "y")
            {
                Console.WriteLine("正在整理中……");

                zhengli(path, path);


                Console.WriteLine("整理完成！");
                Console.Read();


            }



        }

        private static void zhengli(string path, string zi)
        {
           
            List<string> listExten = new List<string>();

            DirectoryInfo DInfo = new DirectoryInfo(zi);
            FileInfo[] FInfos = DInfo.GetFiles();
            string strExten = "";
            foreach (FileInfo FInfo in FInfos)
            {
                strExten = FInfo.Extension;
                if (!listExten.Contains(strExten))
                {
                    listExten.Add(strExten.TrimStart('.'));
                }
            }
            for (int i = 0; i < listExten.Count; i++)
            {
                Directory.CreateDirectory(path + "\\整理_" + listExten[i]);
            }
            foreach (FileInfo FInfo in FInfos)
            {
               int flag = 1;
                string target = path + "\\整理_" + FInfo.Extension.TrimStart('.') + "\\" + FInfo.Name;
                string farget_name = "";
                while(File.Exists(target))//如果有重名的文件就重命名
                {
                    
                    string temp="";
                    string[] tmp = FInfo.Name.Split('.');
                    temp = tmp[0] +"("+ flag.ToString()+")";
                    farget_name = temp + "."+ FInfo.Extension;

                    target = path + "\\整理_" + FInfo.Extension.TrimStart('.') + "\\" + farget_name;
                    flag++;
                }


              FInfo.MoveTo(target);
            }




            string[] zimulu;
            zimulu = Directory.GetDirectories(zi);
            foreach (string s in zimulu)
            {
                zhengli(path, s);
            }
        }
    }
}
