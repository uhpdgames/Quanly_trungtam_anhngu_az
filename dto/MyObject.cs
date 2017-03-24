using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class TempItemReadFileBM4
    {
        public string _StudentID;
        public string _StudentName;
        public float _DiemMieng;
        public float _Diem15Phut;
        public float _Diem45Phut;
        public float _DiemThiHocKy;
        public float _DiemTrungBinh;

        public TempItemReadFileBM4()
        {
            _StudentID = "";
            _StudentName = "";
            _DiemMieng = 0.0f;
            _Diem15Phut = 0.0f;
            _Diem45Phut = 0.0f;
            _DiemThiHocKy = 0.0f;
            _DiemTrungBinh = 0.0f;

        }
    }
    public enum TypeOfUser
    {
        Admin,
        LeaderShip, // ban giám hiệu
        Ministry,   // giáo vụ
        Other,

    };

    public class MyDateTime
    {
        public int _Day;
        public int _Month;
        public int _Year;

        public MyDateTime()
        {
            _Day = 0;
            _Month = 0;
            _Year = 0;
        }
        public MyDateTime(int day, int month, int year)
        {
            _Day = day;
            _Month = month;
            _Year = year;
        }

        public void SetTrueDateTime()
        {
            int dd = 1;
            if (_Day != 0 && _Month != 0 && _Year != 0)
            {

                switch (_Month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dd = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dd = 30;
                        break;
                    case 2:
                        if (((_Year % 4 == 0) && (_Year % 100 != 0)) || (_Year % 400 == 0))
                            dd = 29;
                        else
                            dd = 28;
                        break;
                }
            }
            if (_Day < 1)
                _Day = 1;
            if (_Day > dd)
                _Day = dd;
            if (_Month > 12)
                _Month = 12;
            if (_Month < 1)
                _Month = 1;
            if (_Year < 1900)
                _Year = 1900;
            if (_Year > (DateTime.Now.Year - 1))
                _Year = DateTime.Now.Year - 1;

        }

        public string ToStringDDMMYY()
        {
            return (_Day + "/" + _Month + "/" + _Year);
        }
        public string ToStringMMDDYY()
        {
            return (_Month + "/" + _Day + "/" + _Year);
        }

        public bool SetDateTimeFromString(string datetimeString) //  format datetime string : "dd/mm/yy"
        {
            try
            {
                datetimeString = '/' + datetimeString + '/';
                string pattern = "(?<=/).*?(?=/)";
                Regex regex = new Regex(pattern);
                MatchCollection mc = regex.Matches(datetimeString);
                _Day = int.Parse(mc[0].Value);
                _Month = int.Parse(mc[1].Value);
                _Year = int.Parse(mc[2].Value);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class ItemBM5_BCTK
    {
        public string _MaLop;
        public int _SiSo;
        public int _SoLuongDat;
        public float _TiLeDat;

        public ItemBM5_BCTK()
        {
            _MaLop = "";
            _SiSo = 0;
            _SoLuongDat = 0;
            _TiLeDat = 0;
        }
    }

    public class ItemBm3TCHS
    {
        public string _StudentID;
        public string _ClassName;
        public string _StudentName;
        public int _StudentGender; // 1. male, 2. female, 3.other
        public MyDateTime _StudentBirthday;
        public string _StudentAddress;
        public string _StudentEmail;
        public MyDateTime _AdmissionDay; // ngay nhap hoc
        public float _ScoreAvg;
    }

}
