using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Entities;

namespace WorkshopManager.Core.Abstractions.WS.Repos
{
    /// <summary>
    /// Teams repository.
    /// </summary>
    public interface IWSTeamsRepo
    {
        /// <summary>
        /// Adds a team to the repository.
        /// </summary>
        /// <param name="team">Team</param>
        void Add(WSTeam team);
        /// <summary>
        /// Deletes a team from the repository.
        /// </summary>
        /// <param name="id">Id of the team.</param>
        void Delete(int id);
        /// <summary>
        /// Updates team.
        /// </summary>
        /// <param name="updatedTeam">Team</param>
        void Update(WSTeam updatedTeam);
        /// <summary>
        /// Gets all teams.
        /// </summary>
        /// <returns>Collection of teams.</returns>
        IEnumerable<WSTeam> GetAll();
        /// <summary>
        /// Gets team by id.
        /// </summary>
        /// <param name="id">Id of team.</param>
        /// <returns>Team</returns>
        WSTeam Get(int id);
    }
}
