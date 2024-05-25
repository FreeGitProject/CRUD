using CoreV1.Models.Brand;
using CoreV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreV1.Models.Common;

namespace CoreV1.Service.Brand
{
    public interface IBrandService
    {
        List<BrandModel> GetBrands(int? currentPage, int? pageSize, BrandFilter filter, string langCulture);
        BrandModel GetBrand(Guid id, string langCulture);
        List<ImageItem> GetBrandMedia(Guid recordId);
        List<LocalizedEntity> GetLocalizedEntities(Guid entityId, string langCulture = "", string className = "");
        BoolResponse CreateBrand(BrandAddModel model, string langCulture);
        BoolResponse UpdateBrand(BrandSaveModel model, string langCulture);
    }
}
