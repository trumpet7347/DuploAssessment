using System.Reflection.Metadata;
using Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Repositories.Interfaces;

public interface ILocationsRepository
{
    public Task<IEnumerable<Location>> GetLocations();
    public Task<Location?> GetLocation(int locationId);
    public Task<Location> AddLocation(Location newLocation);
    public Task<Location> AddLocation(double latitude, double longitude);
}