using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Entities;

namespace WorkshopManager.Core.Abstractions.WS.Repos
{
    /// <summary>
    /// Team Employee Relations repository.
    /// </summary>
    public interface IWSTeamEmployeeRelationsRepo
    {
        /// <summary>
        /// Adds Team Employee Relation to the repository.
        /// </summary>
        /// <param name="teamEmployeeRelation"></param>
        void Add(WSTeamEmployeeRelation teamEmployeeRelation);

        /// <summary>
        /// Deletes Team Employee Relation from the repository.
        /// </summary>
        /// <param name="teamEmployeeRelation"></param>
        void Delete(WSTeamEmployeeRelation teamEmployeeRelation);

        /// <summary>
        /// Gets Team Employee Relation by Team Id and Employee Id.
        /// </summary>
        /// <param name="teamEmployeeRelation"></param>
        /// <returns>Team Employee Relation</returns>
        WSTeamEmployeeRelation Get(WSTeamEmployeeRelation teamEmployeeRelation);

        /// <summary>
        /// Gets all Team Employee Relations.
        /// </summary>
        /// <returns></returns>
        IEnumerable<WSTeamEmployeeRelation> GetAll();
    }
}
