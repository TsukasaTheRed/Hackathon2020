using Microsoft.EntityFrameworkCore;

namespace hackAThon2020ContactTracker.Models
{
    public class ContactsContext : DbContext {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options) {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}