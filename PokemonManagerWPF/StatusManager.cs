namespace StatusManager
{
		public class Status
		{
				public Status(int[] e, int[] i)
				{
						EffortValue = e;
						IndividualValue = i;
				}
				public Status()
				{

				}
				public int[] EffortValue
				{
						get
						{
								return effortvalue;
						}
						private set
						{
								effortvalue = value;
						}
				}
				public int[] IndividualValue
				{
						get
						{
								return individualvalue;
						}
						private set
						{
								individualvalue = value;
						}
				}
				int[] effortvalue = new int[6] { 0, 0, 0, 0, 0, 0 };
				int[] individualvalue = new int[6] { 0, 0, 0, 0, 0, 0 };
		}
}