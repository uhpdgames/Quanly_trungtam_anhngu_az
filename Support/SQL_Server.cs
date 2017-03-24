using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    public class SQL_Server
    {
        public static string _CurrentUser; // tên đăng nhập ứng dụng
        public static string _CurrentPassword; // mật khẩu đăng nhập ứng dụng - được băm dưới dạng mã MD5
        public static TypeOfUser _CurrentTypeOfUser; // loại người dùng hiện tại - đảm bảo phân quyền sử dụng
        public static bool _IsLogin; // đăng nhập được vào tài khoản người dùng ứng dụng ?

        public static string _ConnectionStringToMaster; // ConnectionString cho kết nối đến Master
        public static string _ConnectionStringToMyDB; // ConnectionString cho kết nối đến Database hiện tại

        public static bool _IsReadyWorking;

    }
}
