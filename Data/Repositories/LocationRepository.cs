using Data.Models;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Repositories;

public class LocationRepository: ILocationsRepository
{
    private readonly DataContext _context;
    
    public LocationRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Location>> GetLocations()
    {
        return await _context.Locations.ToListAsync();
    }

    public async Task<Location?> GetLocation(int locationId)
    {
        return await _context.Locations.FirstOrDefaultAsync(l => l.LocationId == locationId);
    }

    public async Task<Location> AddLocation(Location newLocation)
    {
        _context.Locations.Add(newLocation);
        await _context.SaveChangesAsync();
        return newLocation;
    }

    public async Task<Location> AddLocation(double latitude, double longitude)
    {
        var location = new Location()
        {
            Latitude = latitude,
            Longitude = longitude
        };

        _context.Locations.Add(location);
        await _context.SaveChangesAsync();
        return location;
    }
}