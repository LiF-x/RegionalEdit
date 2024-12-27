/**
* <author>WarpedIbun & Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits></credits>
* <description>Add Extra Regions to your life is feudal your own server!</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxRegions))
{
    new ScriptObject(LiFxRegions)
    {
    };
}

package LiFxRegions {
  function LiFxRegions::setup() {
    LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, RegionalAddition, LiFxRegions);
  }

  function LiFxRegions::version() {
    return "1.0.0";
  }
  function LiFxRegions::RegionalAddition() {

  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2423)"); // Icy Hermits
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2424)"); // Chilling Thickets
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2425)"); // Rocky Plains
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2426)"); // Central domain
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2427)"); // Western Domain
                                                             // 2328 is Sleepers tongs
                                                             // 2329 Is Sleepers Hammer
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2430)"); // Southern Drifters
                                                             // 2431 is Sleepers Forge
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2432)"); // Parched Winds
  dbi.Update("INSERT IGNORE `regions` VALUES (NULL, 2433)"); // Wardens of the East

  // Regional mapping
  dbi.Update("TRUNCATE TABLE `neighbor_regions`");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (1, 12, 13 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 12, 15 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 13, 12 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 13, 14 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 13, 16 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 14, 13 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 14, 17 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 15, 12 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 15, 16 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 15, 18 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 16, 13 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 16, 15 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 16, 17 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 16, 19 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 17, 14 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 17, 16 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 17, 20 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 18, 15 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 18, 19 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 19, 16 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 19, 18 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 19, 20 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 20, 17 )");
  dbi.Update("INSERT IGNORE `neighbor_regions` VALUES (NULL, 20, 19 )");
  
  // Update terrain_blocks table
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '12' WHERE ID = 442");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '13' WHERE ID = 443");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '14' WHERE ID = 444");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '15' WHERE ID = 445");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '16' WHERE ID = 446");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '17' WHERE ID = 447");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '18' WHERE ID = 448");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '19' WHERE ID = 449");
  dbi.Update("UPDATE `terrain_blocks` SET  RegionID = '20' WHERE ID = 450");
  }  
};
activatePackage(LiFxRegions);