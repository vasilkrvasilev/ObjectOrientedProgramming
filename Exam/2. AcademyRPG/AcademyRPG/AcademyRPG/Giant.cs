using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private bool hasIncreased = false;

        public Giant(string name, Point position, int owner = 0)
            : base(name, position, owner)
        {
            this.HitPoints = 200;
        }

        public int AttackPoints
        {
            get { return 150; }
            private set { this.AttackPoints = value; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (this.hasIncreased == false)
                {
                    this.AttackPoints += 100;
                    this.hasIncreased = true;
                }
                return true;
            }

            return false;
        }
    }
}
