using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Event
    {
        private ProcessState processState;
        private Users users;
        private DateTime checkOutDate;
        private DateTime checkInDate;

        public Event(ProcessState processState, Users users, DateTime checkOutDate, DateTime checkInDate)
        {
            this.processState = processState;
            this.users = users;
            this.checkOutDate = checkOutDate;
            this.checkInDate = checkInDate;
        }

        public ProcessState getProcessState()
        {
            return this.processState;
        }

        public void setProcessState(ProcessState processState)
        {
            this.processState = processState;
        }

        public Users getUsers()
        {
            return this.users;
        }

        public void setUsers(Users users)
        {
            this.users = users;
        }

        public DateTime getCheckOutDate()
        {
            return this.checkOutDate;
        }

        public void setCheckOutDate(DateTime checkOutDate)
        {
            this.checkOutDate = checkOutDate;
        }

        public DateTime getCheckInDate()
        {
            return this.checkInDate;
        }

        public void setCheckInDate(DateTime checkInDate)
        {
            this.checkInDate = checkInDate;
        }

        public override string ToString()
        {
            return this.processState.ToString() + "   Person: " + this.users.ToString() + " Check in date: " + this.checkInDate.ToString() + " Check out date: " + this.checkOutDate.ToString();
        }
    }
}
