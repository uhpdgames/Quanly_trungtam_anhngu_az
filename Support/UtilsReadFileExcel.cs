
//using DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace Support
//{
//    public class UtilsReadFileExcel
//    {

//        public static List<HocSinh> InputStudentBM1FromExcel(string filePath)
//        {
//            try
//            {
//                List<HocSinh> getAllStudent = new List<HocSinh>();
//                Microsoft.Office.Interop.Excel.Workbook MyBook = null;
//                Microsoft.Office.Interop.Excel.Application MyApp = null;
//                Microsoft.Office.Interop.Excel.Worksheet MySheet = null;
//                Microsoft.Office.Interop.Excel.Range MyRange = null;

//                MyApp = new Microsoft.Office.Interop.Excel.Application();
//                MyApp.Visible = false;
//                MyBook = MyApp.Workbooks.Open(filePath);
//                MySheet = (Microsoft.Office.Interop.Excel.Worksheet)MyBook.Sheets[1];
//                MyRange = MySheet.UsedRange;

//                for (int row = 2; row < MyRange.Rows.Count; row++)
//                {
//                    HocSinh student = new HocSinh();
//                    int col = 1;
//                    student._TenHocSinh = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;

//                    string gender = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    int a = 0;
//                    if (gender == "Nam" || gender == "NAM" || gender == "nam")
//                        a = 0;
//                    else if (gender == "Nu" || gender == "NU" || gender == "nu" || gender == "NỮ" || gender == "nữ" || gender == "Nữ")
//                        a = 1;
//                    else
//                        a = 2;
//                    student._GioiTinh = a;

//                    double d = (MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    DateTime dt = DateTime.FromOADate(d);
//                    student._NgaySinh = new MyDateTime(dt.Day, dt.Month, dt.Year);
//                    student._DiaChi = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    student._Email = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    getAllStudent.Add(student);

//                }

//                MyBook.Close(true, null, null);
//                MyApp.Quit();

//                releaseObject(MySheet);
//                releaseObject(MyBook);
//                releaseObject(MyApp);
//                return getAllStudent;

//            }
//            catch
//            {
//                return null;
//            }
//        }

//        public static List<HocSinh> InputClassStudentBM2FromExcel(string filePath, ref string className, ref int countStudent, ref string scholastic, ref string semester)
//        {
//            try
//            {
//                List<HocSinh> getAllStudent = new List<HocSinh>();
//                Microsoft.Office.Interop.Excel.Workbook MyBook = null;
//                Microsoft.Office.Interop.Excel.Application MyApp = null;
//                Microsoft.Office.Interop.Excel.Worksheet MySheet = null;
//                Microsoft.Office.Interop.Excel.Range MyRange = null;

//                MyApp = new Microsoft.Office.Interop.Excel.Application();
//                MyApp.Visible = false;
//                MyBook = MyApp.Workbooks.Open(filePath);
//                MySheet = (Microsoft.Office.Interop.Excel.Worksheet)MyBook.Sheets[1];
//                MyRange = MySheet.UsedRange;

//                className = (string)(MyRange.Cells[1, 1] as Excel.Range).Value2;
//                semester = (string)(MyRange.Cells[1, 2] as Excel.Range).Value2;
//                scholastic = (string)(MyRange.Cells[1, 3] as Excel.Range).Value2;
//                countStudent = (int)MyRange.Rows.Count - 2;
//                for (int row = 3; row <= MyRange.Rows.Count; row++)
//                {
//                    HocSinh student = new HocSinh();
//                    int col = 1;
//                    student._TenHocSinh = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    string gender = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    int a = 0;
//                    if (gender == "Nam" || gender == "NAM" || gender == "nam")
//                        a = 0;
//                    else if (gender == "Nu" || gender == "NU" || gender == "nu" || gender == "NỮ" || gender == "nữ" || gender == "Nữ")
//                        a = 1;
//                    else
//                        a = 2;
//                    student._GioiTinh = a;
//                    double d = (MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    DateTime dt = DateTime.FromOADate(d);
//                    student._NgaySinh = new MyDateTime(dt.Day, dt.Month, dt.Year);
//                    student._DiaChi = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    getAllStudent.Add(student);

//                }

//                MyBook.Close(true, null, null);
//                MyApp.Quit();

//                releaseObject(MySheet);
//                releaseObject(MyBook);
//                releaseObject(MyApp);
//                return getAllStudent;

//            }
//            catch
//            {
//                return null;
//            }
//        }

//        public static List<TempItemReadFileBM4> InputClassStudentBM4FromExcel(string filePath, ref string className, ref string scholastic, ref string semester, ref string course)
//        {
//            try
//            {
//                List<TempItemReadFileBM4> getAlldata = new List<TempItemReadFileBM4>();
//                Microsoft.Office.Interop.Excel.Workbook MyBook = null;
//                Microsoft.Office.Interop.Excel.Application MyApp = null;
//                Microsoft.Office.Interop.Excel.Worksheet MySheet = null;
//                Microsoft.Office.Interop.Excel.Range MyRange = null;

//                MyApp = new Microsoft.Office.Interop.Excel.Application();
//                MyApp.Visible = false;
//                MyBook = MyApp.Workbooks.Open(filePath);
//                MySheet = (Microsoft.Office.Interop.Excel.Worksheet)MyBook.Sheets[1];
//                MyRange = MySheet.UsedRange;

//                className = (string)(MyRange.Cells[1, 1] as Excel.Range).Value2;
//                semester = (string)(MyRange.Cells[1, 2] as Excel.Range).Value2;
//                scholastic = (string)(MyRange.Cells[1, 3] as Excel.Range).Value2;
//                course = (string)(MyRange.Cells[1, 4] as Excel.Range).Value2;
//                for (int row = 3; row <= MyRange.Rows.Count; row++)
//                {
//                    TempItemReadFileBM4 data = new TempItemReadFileBM4();
//                    int col = 1;
//                    data._StudentName = (string)(MyRange.Cells[row, col++] as Excel.Range).Value2;
//                    data._DiemMieng = (float)((MyRange.Cells[row, col++] as Excel.Range).Value2);
//                    data._Diem15Phut = (float)((MyRange.Cells[row, col++] as Excel.Range).Value2);
//                    data._Diem45Phut = (float)((MyRange.Cells[row, col++] as Excel.Range).Value2);
//                    data._DiemThiHocKy = (float)((MyRange.Cells[row, col++] as Excel.Range).Value2);
//                    getAlldata.Add(data);

//                }

//                MyBook.Close(true, null, null);
//                MyApp.Quit();

//                releaseObject(MySheet);
//                releaseObject(MyBook);
//                releaseObject(MyApp);
//                return getAlldata;

//            }
//            catch
//            {
//                return null;
//            }
//        }

//        private static void releaseObject(object obj)
//        {
//            try
//            {
//                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
//                obj = null;
//            }
//            catch (Exception ex)
//            {
//                obj = null;
//                throw (ex);
//            }
//            finally
//            {
//                GC.Collect();
//            }
//        }

//    }
//}
