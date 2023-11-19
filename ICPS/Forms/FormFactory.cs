using ICPS.Forms.Templates;

namespace ICPS.Forms
{
	static class FormFactory
	{
		public static CRUDForm CreateCRUD(){
			return new CRUDForm();
		}
	}
}
