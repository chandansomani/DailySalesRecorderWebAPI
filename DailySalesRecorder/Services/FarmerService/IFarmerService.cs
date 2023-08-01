using DailySalesRecorder.Models;

namespace DailySalesRecorder.Services.FarmerService
{
    public interface IFarmerService
    {
        Task<Farmer> View(int id);
        List<Farmer> ViewAll();
        Task<Farmer> AddFarmer(Farmer farmer);
        Farmer DeleteFarmer(Farmer farmer);
        Farmer AlterFarmer(Farmer farmer);
    }
}
