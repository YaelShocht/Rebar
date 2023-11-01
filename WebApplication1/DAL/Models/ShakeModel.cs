﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DAL.Models;

public class ShakeModel
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]

    public Guid Id { get;set; }
    public string NameShake { get; set; }
    public string Description { get; set; }
    public double PriceL { get; set; }
    public double PriceM { get; set; }
    public double PriceS { get; set; }

    public ShakeModel()
    {
        Id = Guid.NewGuid();
    }
}
