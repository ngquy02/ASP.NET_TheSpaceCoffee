using Web_TheSpaceCoffee.Models;

namespace Web_TheSpaceCoffee.Repository
{
    public class Category : ICategory
    {
        private readonly QlbanCafeNhom04N04Context db = new QlbanCafeNhom04N04Context();

        public Category(QlbanCafeNhom04N04Context db)
        {
            this.db = db;
        }

        public TbNhomSanPham Add(TbNhomSanPham nhomSanPham)
        {
            throw new NotImplementedException();
        }

        public TbNhomSanPham Delete(string maNhomSP)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TbNhomSanPham> GetAllCategory()
        {
            return db.TbNhomSanPhams;
        }

        public TbNhomSanPham GetCategory(string maNhomSP)
        {
            return db.TbNhomSanPhams.Find(maNhomSP);
        }

        public TbNhomSanPham Update(TbNhomSanPham nhomSanPham)
        {
            throw new NotImplementedException();
        }
    }
}
