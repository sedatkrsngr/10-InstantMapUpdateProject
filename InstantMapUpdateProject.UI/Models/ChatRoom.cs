using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantMapUpdateProject.UI.Models
{
    public class ChatRoom
    {
        [BsonId]
        public ObjectId _Id { get; set; }
        
        public string RoomId { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int __v { get; set; }
    }
}
