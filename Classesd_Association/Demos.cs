using System;
using System.Collections.Generic;
using System.Text;

namespace Classesd_Association
{
    
    class Demos
    {
        public static void Inheritance()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        public static void Composition()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
