using AutoMobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.DataAccess
{
    public class NguoiDungDBContext: BaseDAL
    {
        private static NguoiDungDBContext instance;
        private static readonly object instanceLock = new object();
        public NguoiDungDBContext() { }
        public static NguoiDungDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NguoiDungDBContext();
                    }
                    return instance;
                }
            }
        }

        public NguoiDung GetInfo(string tenDangNhap, string matKhau)
        {
            NguoiDung nguoiDung = null;
            IDataReader reader = null;
            var parameters = new List<SqlParameter>();
            string sql = "Select * from NguoiDung where TenDangNhap like @TenDangNhap and MatKhau like @MatKhau";
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, tenDangNhap, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@MatKhau", 50, matKhau, DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                if (reader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        TenDangNhap = reader.GetString(0),
                        MatKhau = reader.GetString(1),
                        LoaiNguoiDung = reader.GetInt32(2),
                        MaNguoiDung = reader.GetInt32(3)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return nguoiDung;
        }

        public IEnumerable<NguoiDung> GetNguoiDungList()
        {
            IDataReader reader = null;
            string sql = "Select * from NguoiDung";
            var nguoiDungs = new List<NguoiDung>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    nguoiDungs.Add(new NguoiDung
                    {
                        TenDangNhap = reader.GetString(0),
                        MatKhau = reader.GetString(1),
                        LoaiNguoiDung = reader.GetInt32(2),
                        MaNguoiDung = reader.GetInt32(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return nguoiDungs;
        }

        public IEnumerable<NguoiDung> GetNguoiDungByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "Select * from NguoiDung where TenDangNhap like @TenDangNhap";
            var parameters = new List<SqlParameter>();
            var nguoiDungs = new List<NguoiDung>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, "%" + tuKhoa + "%", DbType.String));
                //parameters.Add(dataProvider.CreateParameter("@LoaiNguoiDung", 4, tuKhoa, DbType.Int32));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    nguoiDungs.Add(new NguoiDung
                    {
                        TenDangNhap = reader.GetString(0),
                        MatKhau = reader.GetString(1),
                        LoaiNguoiDung = reader.GetInt32(2),
                        MaNguoiDung = reader.GetInt32(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return nguoiDungs;
        }

        public NguoiDung GetNguoiDungByTenDangNhap(string tenDangNhap)
        {
            NguoiDung nd = null;
            IDataReader reader = null;
            string sql = "Select * from NguoiDung where TenDangNhap like @TenDangNhap";
            try
            {
                var param = dataProvider.CreateParameter("@TenDangNhap", 50, tenDangNhap, DbType.String);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    nd = new NguoiDung
                    {
                        TenDangNhap = reader.GetString(0),
                        MatKhau = reader.GetString(1),
                        LoaiNguoiDung = reader.GetInt32(2),
                        MaNguoiDung = reader.GetInt32(3)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return nd;
        }

        public void AddNew(NguoiDung nd)
        {
            try
            {
                NguoiDung k = GetNguoiDungByTenDangNhap(nd.TenDangNhap);
                if (k == null)
                {
                    string sql = "INSERT INTO NguoiDung(TenDangNhap, MatKhau, LoaiNguoiDung, MaNguoiDung) Values(@TenDangNhap, @MatKhau, @LoaiNguoiDung, @MaNguoiDung)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, nd.TenDangNhap, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@MatKhau", 50, nd.MatKhau, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@LoaiNguoiDung", 4, nd.LoaiNguoiDung, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MaNguoiDung", 4, nd.MaNguoiDung, DbType.Int32));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(NguoiDung nd)
        {
            try
            {
                NguoiDung k = GetNguoiDungByTenDangNhap(nd.TenDangNhap);
                if (k != null)
                {
                    string sql = "UPDATE NguoiDung set TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, LoaiNguoiDung=@LoaiNguoiDung, MaNguoiDung=@MaNguoiDung where TenDangNhap like @TenDangNhap";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, nd.TenDangNhap, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@MatKhau", 50, nd.MatKhau, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@LoaiNguoiDung", 4, nd.LoaiNguoiDung, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MaNguoiDung", 4, nd.MaNguoiDung, DbType.Int32));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(string tenDangNhap)
        {
            try
            {
                NguoiDung nd = GetNguoiDungByTenDangNhap(tenDangNhap);
                if (nd != null)
                {
                    string sql = "DELETE NguoiDung where TenDangNhap like @TenDangNhap";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 4, tenDangNhap, DbType.Int32));
                    dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
