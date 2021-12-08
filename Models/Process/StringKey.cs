using System;
using System.Text.RegularExpressions;
namespace NetCore.Models
{
    public class StringKey
    {
        public string GenerateKey (string id){
            // khai báo 1 biến để chứa giá trị của Mã sản phẩm
            string strkey = "";
            // khai báo 2 biến để chữa PHẦN SỐ và PHẦN CHỮ của tham số đầu vào (id = "SP001")
            string numPart = "", strPart ="";
            // tách lấy phần SỐ (\d+) của tham số đầu vào ("001")
            numPart = Regex.Match(id, @"\d+").Value;
            // tách lấy phần chữ (\D+) của tham số đầu vào ("SP")
            strPart = Regex.Match(id, @"\D+").Value;
            // khai báo 1 biến kiểu int = phần số tăng lên 1 đơn vị
            // => Convert.Int32("001") => "2"
            int intPart = (Convert.ToInt32(numPart) + 1);
            // thêm các kí tự số 0 (độ dài chuẩn theo quy định)
            // => phần số của mã sản phẩm => "002"
            for (int i = 0; i < numPart.Length - intPart.ToString().Length; i++)
            {
                strPart += "0";
            }
            // ghép phần số và phần chữ để tạo ra mã tự sinh
            // "SP" + "002" = "SP002"
            strkey = strPart + intPart;
            return strkey;
            // trả ra giá trị
        }
    }
}