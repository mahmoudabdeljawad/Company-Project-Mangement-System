using BusniessLayer.DTO;
using BusniessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Repository
{
    public interface IProjectMangerRepository
    {
        List<ProjectManger> AllProjectManger();
        Task InsertProjectManger(ProjectMangerDto ProjectMangerDto);
        void ProjectMangerDelete(string Id);
        ProjectMangerDto ProjectMangerEdit(string Id);
        Task ProjectMangerInsert(ProjectMangerDto PManger, string Id);
        List<ProjectManger> ProjectMangerSearch(string Search);
    }
}
