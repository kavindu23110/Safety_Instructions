using Safety_app.Data.Interfaces;
using Safety_Instructions.Data.Models;

namespace Safety_Instructions.Data.Interfaces
{
    public interface IDatabase
    {
        bool CheckInternetConnection();
        IDatabaseCommon<Instruction> GetData_Instructions();
        IDatabaseCommon<Symptoms> GetData_Symptoms();
    }
}
