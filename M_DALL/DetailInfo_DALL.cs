using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M_Model;

namespace M_DALL
{
    /// <summary>
    /// 商品详情，邵继星，2016-01-18
    /// email:shaojixing@qq.com 
    /// </summary>
    public class DetailInfo_DALL
    {
        /// <summary>
        /// 获取所有商品信息，邵继星 2016-01-18
        /// </summary>
        /// <returns></returns>
        private List<DetailInfo> GetList()
        {
            using (var db = new smarketEntities())
            {
                return db.DetailInfo.ToList();
            }
        }
        /// <summary>
        /// 获取单个商品实体
        /// </summary>
        /// <param name="id">商品id</param>
        /// <returns></returns>
        private DetailInfo GetModel(int id)
        {
            using (var db = new smarketEntities())
            {
                return db.DetailInfo.Where(t => t.ID == id).FirstOrDefault();
            }
        }
        /// <summary>
        /// 获取top 条商品信息
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        private List<DetailInfo> GetListTop(int top)
        {

            using (var db = new smarketEntities())
            {
                return db.DetailInfo.Take(top).ToList();
            }
        }


        
    }
}
