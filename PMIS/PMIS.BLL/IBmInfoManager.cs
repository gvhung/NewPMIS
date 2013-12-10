
namespace PMIS.BLL
{
   public interface IBmInfoManager
    {
        object GetNextCode(string code);

       void GetAndGroupByBm();
    }
}
