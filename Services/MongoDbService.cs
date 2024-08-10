using Nowadays.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Nowadays.Services;

public class MongoDBService
{

    private readonly IMongoCollection<Company> _companyCollection;

    public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _companyCollection = database.GetCollection<Company>(mongoDBSettings.Value.CollectionName);
    }

    public async Task CreateAsync(Company company)
    {
        await _companyCollection.InsertOneAsync(company);
        return;
    }

    public async Task<List<Company>> GetAsync()
    {
        return await _companyCollection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task AddToCompanyAsync(string id, string employeeId)
    {
        FilterDefinition<Company> filterDefinition = Builders<Company>.Filter.Eq("Id", id);
        UpdateDefinition<Company> update = Builders<Company>.Update.AddToSet<string>("employees", employeeId);

        await _companyCollection.UpdateOneAsync(filterDefinition, update);
        return;
    }

    public async Task DeleteAsync(string id)
    {
        FilterDefinition<Company> filterDefinition = Builders<Company>.Filter.Eq("Id", id);

        await _companyCollection.DeleteOneAsync(filterDefinition);
        return;
    }

}
