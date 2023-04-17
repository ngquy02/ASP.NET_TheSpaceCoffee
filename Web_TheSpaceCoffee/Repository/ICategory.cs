using Web_TheSpaceCoffee.Models;

namespace Web_TheSpaceCoffee.Repository
{
    public interface ICategory
    {
        TbNhomSanPham Add(TbNhomSanPham nhomSanPham);

        TbNhomSanPham Update(TbNhomSanPham nhomSanPham);

        TbNhomSanPham Delete(String maNhomSP);

        TbNhomSanPham GetCategory(String maNhomSP);

        IEnumerable<TbNhomSanPham> GetAllCategory();
    }
}
