using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFileDll
{
    public class Class1
    {
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
                Directory.CreateDirectory(path + "\\" + listExten[i]);
            }
            foreach (FileInfo FInfo in FInfos)
            {
                int flag = 1;
                string target = path + "\\" + FInfo.Extension.TrimStart('.') + "\\" + FInfo.Name;
                string farget_name = "";
                while (File.Exists(target))//如果有重名的文件就重命名
                {

                    string temp = "";
                    string[] tmp = FInfo.Name.Split('.');
                    temp = tmp[0] + "(" + flag.ToString() + ")";
                    farget_name = temp + "." + FInfo.Extension;

                    target = path + "\\" + FInfo.Extension.TrimStart('.') + "\\" + farget_name;
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
