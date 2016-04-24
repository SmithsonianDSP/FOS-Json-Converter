Public Class Rootobject
    'Public Property timeMgr As Timemgr
    'Public Property localNotificationMgr As Localnotificationmgr
    'Public Property taskMgr As Taskmgr
    'Public Property ratingMgr As Ratingmgr
    Public Property dwellers As Dwellers
    'Public Property constructMgr As Constructmgr
    Public Property vault As Vault
    'Public Property dwellerSpawner As Dwellerspawner
    'Public Property deviceName As String
    'Public Property tutorialManager As Tutorialmanager
    'Public Property objectiveMgr As Objectivemgr
    'Public Property unlockableMgr As Unlockablemgr
    'Public Property survivalW As Survivalw
    'Public Property happinessManager As Happinessmanager
    'Public Property refugeeSpawner As Refugeespawner
    'Public Property LunchBoxCollectWindow As Object
    'Public Property DeathclawManager As Deathclawmanager
    'Public Property PromoCodesWindow As Object
    'Public Property JunkGiveAwayWindow As Object
    'Public Property MysteriousStranger As Mysteriousstranger
    'Public Property StatsWindow As Statswindow
    'Public Property PromotionFlags() As String()
    'Public Property appVersion As String
    'Public Property swrveEventsManager As Swrveeventsmanager
    'Public Property versionCount As Single
End Class

Public Class Timemgr
    Public Property gameTime As Single
    Public Property time As Single
    Public Property timeSaveDate As Long
    Public Property timeGameBegin As Long
End Class

Public Class Localnotificationmgr
    Public Property UniqueIDS() As Single()
    Public Property AndroidNotifications() As Object()
End Class

Public Class Taskmgr
    Public Property id As Single
    Public Property time As Single
    Public Property tasks() As [Tasks]()
    Public Property pausedTasks() As Object
End Class

Public Class Tasks
    Public Property startTime As Single
    Public Property endTime As Single
    Public Property name As String
    Public Property id As Single
    Public Property paused As Boolean
    Public Property rescheduleToOldest As Boolean
End Class

Public Class Ratingmgr
    Public Property sampleId As Single
    Public Property dayRatingId As Single
    Public Property currentSamples() As Single()
    Public Property ratings() As Rating()
    Public Property ratingsLast() As Ratingslast()
    Public Property hasWeekRating As Boolean
    Public Property hasLastWeekRating As Boolean
    Public Property weekRating As Single
    Public Property lastWeekRating As Single
End Class

Public Class Rating
    Public Property rating As Single
    Public Property time As Single
    Public Property collected As Boolean
End Class

Public Class Ratingslast
    Public Property rating As Single
    Public Property time As Single
    Public Property collected As Boolean
End Class

Public Class Dwellers
    Public Property dwellers() As Dweller()
    Public Property actors() As Actor()
    Public Property id As Single
    Public Property mrhId As Single
    Public Property min_happiness As Single
End Class

Public Class Dweller
    Public Property serializeId As Single
    Public Property name As String
    Public Property lastName As String
    Public Property happiness As Happiness
    Public Property health As Health
    Public Property experience As Experience
    Public Property relations As Relations
    Public Property equipment As Equipment
    Public Property gender As Single
    Public Property stats As Stats
    Public Property pregnant As Boolean
    Public Property babyReady As Boolean
    Public Property assigned As Boolean
    Public Property sawIncident As Boolean
    Public Property WillGoToWasteland As Boolean
    Public Property WillBeEvicted As Boolean
    Public Property IsEvictedWaitingForFollowers As Boolean
    Public Property skinColor As Long
    Public Property hairColor As Long
    Public Property outfitColor As Long
    Public Property pendingExperienceReward As Long
    Public Property uniqueData As String
    Public Property hair As String
    Public Property equipedOutfit As Equipedoutfit
    Public Property equipedWeapon As Equipedweapon
    Public Property equippedPet As Equippedpet
    Public Property savedRoom As Single
    Public Property lastChildBorn As Object
    Public Property rarity As String
    Public Property deathTime As Object
    Public Property daysOnWasteland As Single
    Public Property hoursOnWasteland As Single
    Public Property faceMask As String
End Class

Public Class Happiness
    Public Property happinessValue As Single
End Class

Public Class Health
    Public Property healthValue As Single
    Public Property radiationValue As Single
    Public Property permaDeath As Boolean
    Public Property lastLevelUpdated As Single
    Public Property maxHealth As Single
End Class

Public Class Experience
    Public Property experienceValue As Single
    Public Property currentLevel As Single
    Public Property storage As Single
    Public Property accum As Single
    Public Property needLvUp As Boolean
    Public Property wastelandExperience As Single
End Class

Public Class Relations
    'Public Property relations() As Object()
    'Public Property partner As Object
    'Public Property lastPartner As Object
    'Public Property ascendants() As Object()
End Class

Public Class Equipment
    Public Property storage As Storage
    Public Property inventory As Inventory
End Class

Public Class Storage
    Public Property resources As Resources
    Public Property bonus As Bonus
End Class

Public Class Resources
    'Public Property Nuka As Single
    'Public Property Food As Single
    'Public Property Energy As Single
    'Public Property Water As Single
    'Public Property StimPack As Single
    'Public Property RadAway As Single
    'Public Property Lunchbox As Single
    'Public Property MrHandy As Single
    'Public Property PetCarrier As Single
    'Public Property CraftedOutfit As Single
    'Public Property CraftedWeapon As Single
End Class

Public Class Bonus
    'Public Property Nuka As Single
    'Public Property Food As Single
    'Public Property Energy As Single
    'Public Property Water As Single
    'Public Property StimPack As Single
    'Public Property RadAway As Single
    'Public Property Lunchbox As Single
    'Public Property MrHandy As Single
    'Public Property PetCarrier As Single
    'Public Property CraftedOutfit As Single
    'Public Property CraftedWeapon As Single
End Class

Public Class Inventory
    Public Property items() As Items()
End Class

Public Class Items
    Public Property id As String
    Public Property type As String
    Public Property hasBeenAssigned As Boolean
    Public Property hasRandonWeaponBeenAssigned As Boolean
    Public Property extraData As Extradata
End Class

Public Class Extradata
    Public Property isRecipe As Boolean
End Class

Public Class Stats
    Public Property stats() As Stat()
End Class

Public Class Stat
    Public Property value As Single
    Public Property [mod] As Single
    Public Property exp As Single
End Class

Public Class Equipedoutfit
    Public Property id As String
    Public Property type As String
    Public Property hasBeenAssigned As Boolean
    Public Property hasRandonWeaponBeenAssigned As Boolean
End Class

Public Class Equipedweapon
    Public Property id As String
    Public Property type As String
    Public Property hasBeenAssigned As Boolean
    Public Property hasRandonWeaponBeenAssigned As Boolean
End Class

Public Class Equippedpet
    Public Property id As String
    Public Property type As String
    Public Property hasBeenAssigned As Boolean
    Public Property hasRandonWeaponBeenAssigned As Boolean
    Public Property extraData As Extradata1
End Class

Public Class Extradata1
    Public Property uniqueName As String
    Public Property bonus As String
    Public Property bonusValue As Single
End Class

Public Class Actor
    Public Property characterType As Single
    Public Property actorDataId As String
    Public Property serializeId As Single
    Public Property name As String
    Public Property canCollect As Boolean
    Public Property willGoToWasteland As Boolean
    Public Property equipment As Equipment1
    Public Property health As Single
    Public Property death As Boolean
    Public Property savedRoom As Single
    Public Property FollowedID As Single
End Class

Public Class Equipment1
    Public Property storage As Storage1
    Public Property inventory As Inventory1
End Class

Public Class Storage1
    Public Property resources As Resources
    Public Property bonus As Bonus
End Class


Public Class Inventory1
    Public Property items() As Object()
End Class

Public Class Constructmgr
    Public Property roomDeserializeID As Single
End Class

Public Class Vault
    Public Property rocks() As Object()
    Public Property rooms() As Room()
    Public Property storage As Storage2
    Public Property inventory As Inventory2
    Public Property emergencyData As Emergencydata
    Public Property roomConsumption As Roomconsumption
    Public Property dwellerWaterConsumption As Dwellerwaterconsumption
    Public Property dwellerFoodConsumption As Dwellerfoodconsumption
    Public Property lunchboxRandomGenerator As String
    Public Property LunchBoxesByType() As Single()
    Public Property LunchBoxesCount As Single
    Public Property VaultName As String
    Public Property VaultMode As String
    Public Property VaultTheme As Single
    Public Property Achievements As Achievements
    Public Property wasteland As Wasteland
End Class

Public Class Storage2
    Public Property resources As Resources
    Public Property bonus As Bonus
End Class

Public Class Inventory2
    Public Property items() As Item1()
End Class

Public Class Item1
    Public Property id As String
    Public Property type As String
    Public Property hasBeenAssigned As Boolean
    Public Property hasRandonWeaponBeenAssigned As Boolean
    Public Property extraData As Extradata2
End Class

Public Class Extradata2
    Public Property uniqueName As String
    Public Property bonus As String
    Public Property bonusValue As Single
End Class

Public Class Emergencydata
    Public Property active As Boolean
    Public Property randomEventTaskId As Single
End Class

Public Class Roomconsumption
    Public Property taskIdOnline As Single
    Public Property taskIDShutDown As Single
End Class

Public Class Dwellerwaterconsumption
    Public Property taskIdOnline As Single
End Class

Public Class Dwellerfoodconsumption
    Public Property taskIdOnline As Single
End Class

Public Class Achievements
    Public Property objectivesInProgress() As Objectivesinprogress()
    Public Property completed() As String()
End Class

Public Class Objectivesinprogress
    Public Property objectiveID As String
    Public Property requirements() As Requirement()
    Public Property completed As Boolean
    Public Property incrementLevel As Single
End Class

Public Class Requirement
    Public Property requirementID As String
    Public Property satisfied As Boolean
    Public Property rushCount As Single
    Public Property higherMergeLevelFound As Single
    Public Property currentBabies As Single
    Public Property acceptedRoom As Single
    Public Property currentInvasions As Single
    Public Property numberOfObjectivesCompleted As Single
    Public Property currentLegendaryDwellers As Single
    Public Property currentLegendaryOutfits As Single
    Public Property currentLegendaryWeapons As Single
End Class

Public Class Wasteland
    Public Property state As State
    Public Property teams() As Team()
    Public Property cycles() As Cycle()
    Public Property mrHandyCycles() As Mrhandycycle()
    Public Property allTimeTeamsCounter As Single
End Class

Public Class State
    Public Property name As String
End Class

Public Class Team
    Public Property dwellers() As Single()
    Public Property returnTripDuration As Single
    Public Property elapsedTimeAliveExploring As Single
    Public Property elapsedReturningTime As Single
    Public Property teamIndex As Single
    Public Property status As String
    Public Property logs() As String()
    Public Property missedEncounters As Single
    Public Property introMessages As Single
    Public Property notificationID As Single
    Public Property isForceReturningToVault As Boolean
    Public Property actors() As Object()
    Public Property initialItems() As Initialitem()
End Class

Public Class Initialitem
    Public Property initWeapon As String
    Public Property initOutfit As String
    Public Property initPet As String
End Class

Public Class Cycle
    Public Property cycleType As String
    Public Property taskId As Single
    Public Property pendingCycles() As Object()
    Public Property teamEncounters() As Teamencounter()
    Public Property inProgress() As Object()
End Class

Public Class Teamencounter
    Public Property teamEncounters() As Teamencounter1()
    Public Property teamID As Single
End Class

Public Class Teamencounter1
    Public Property nonRepeatable() As String()
    Public Property poolType As String
End Class

Public Class Mrhandycycle
    Public Property cycleType As String
    Public Property taskId As Single
End Class

Public Class Room
    'Public Property emergencyDone As Boolean
    'Public Property type As String
    'Public Property _class As String
    'Public Property mergeLevel As Single
    'Public Property row As Single
    'Public Property col As Single
    'Public Property power As Boolean
    'Public Property roomHealth As Roomhealth
    'Public Property mrHandyList() As Single?()
    'Public Property rushTask As Single
    'Public Property level As Single
    'Public Property dwellers() As Single?()
    'Public Property deadDwellers() As Object()
    'Public Property currentStateName As String
    'Public Property currentState As Currentstate
    'Public Property deserializeID As Single
    'Public Property assignedDecoration As String
    'Public Property broken As Boolean
    'Public Property withHole As Boolean
    'Public Property storage As Storage3
    'Public Property numberOfProductionCycle As Single
    'Public Property ExperienceRewardIsDirty As Boolean
    'Public Property slots() As Slot()
    'Public Property dwellerWithPendingCompleteTraining() As Object()
    'Public Property children() As Object()
    'Public Property partners() As Object()
    'Public Property IngredientItemIds() As Object()
    'Public Property CraftingItemId As String
    'Public Property CompletedTime As Single
End Class

Public Class Roomhealth
    Public Property damageValue As Single
End Class

Public Class Currentstate
    Public Property taskId As Single
    Public Property notificationId As String
End Class

Public Class Storage3
    Public Property resources As Resources3
    Public Property bonus As Bonus3
End Class

Public Class Resources3
    Public Property Nuka As Single
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Single
    Public Property RadAway As Single
    Public Property Lunchbox As Single
    Public Property MrHandy As Single
    Public Property PetCarrier As Single
    Public Property CraftedOutfit As Single
    Public Property CraftedWeapon As Single
End Class

Public Class Bonus3
    Public Property Nuka As Single
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Single
    Public Property RadAway As Single
    Public Property Lunchbox As Single
    Public Property MrHandy As Single
    Public Property PetCarrier As Single
    Public Property CraftedOutfit As Single
    Public Property CraftedWeapon As Single
End Class

Public Class Slot
    Public Property needLvUp As Boolean
    Public Property dwellerID As Single
    Public Property taskID As Single
End Class

Public Class Dwellerspawner
    Public Property dwellersWaiting() As Object()
End Class

Public Class Tutorialmanager
    Public Property phase As String
    Public Property taskNumber As Single
    Public Property objectivesTutorialMessage As Boolean
    Public Property lunchboxTutorialMessage As Boolean
    Public Property showingObjectiveTutorialMessage As Boolean
    Public Property showingLunchboxTutorialMessage As Boolean
    Public Property showWastelandMessageTime As Single
    Public Property showExploreWastelandMessageTime As Single
    Public Property exploreWastelandMessageShown As Boolean
    Public Property skippedTutorial As Single
    Public Property intialTimerTasks() As Object()
    Public Property ContextualVaultTecObjectives As Boolean
    Public Property ContextualAddFriends As Boolean
    Public Property ContextualWasteland As Boolean
    Public Property ContextualRadioRoom As Boolean
    Public Property ContextualWeaponsAndOutfits As Boolean
    Public Property ContextualTrainDweller As Boolean
    Public Property ContextualBabies As Boolean
    Public Property ContextualDestroyRocks As Boolean
    Public Property ContextualStorage As Boolean
    Public Property ContextualNoRoomForDwellers As Boolean
    Public Property ContextualUnequipedDweller As Boolean
    Public Property ContextualBuildAnElevator As Boolean
    Public Property ContextualDestroyRockToBuild As Boolean
    Public Property ContextualNoBuildZonesAvailableByRock As Boolean
    Public Property ContextualDestroyRockToAccessNextFloor As Boolean
    Public Property ContextualResourcesAlert As Boolean
    Public Property ContextualIncidentOcurs As Boolean
    Public Property ContextualLowPowerAlert As Boolean
    Public Property ContextualStorageFull As Boolean
    Public Property ContextualMergeOrUpgradeRoom As Boolean
    Public Property ContextualWastelandMessage As Boolean
    Public Property ContextualObjectivesCompleted As Boolean
    Public Property ContextualBabiesTutorial As Boolean
    Public Property ContextualStimpackMessage As Boolean
    Public Property ContextualLunchboxTutorial As Boolean
    Public Property ContextualRadwayMessage As Boolean
    Public Property ContextualRoomMerge2 As Boolean
    Public Property ContextualRoomMerge3 As Boolean
    Public Property ContextualStorage2 As Boolean
    Public Property ContextualEquippingItemsWeapon As Boolean
    Public Property ContextualLuck As Boolean
    Public Property ContextualEquppingItemsPet As Boolean
    Public Property ContextualCrafting As Boolean
    Public Property ContextualDecorations As Boolean
    Public Property ContextualRequestJunk As Boolean
    Public Property ContextualJunk As Boolean
    Public Property ContextualTriggeredBirth As Boolean
    Public Property ContextualInventoryFull As Boolean
    Public Property ContextualInventoryFullWindow As Boolean
    Public Property ContextualJunkGiveAway As Boolean
    Public Property ContextualScrapping As Boolean
    Public Property ContextualAssignWith3DTouch As Boolean
    Public Property MaleTasksQuant As Single
    Public Property FemaleTasksQuant As Single
End Class

Public Class Objectivemgr
    Public Property taskID As Single
    Public Property canDiscard As Boolean
    Public Property shuffleBags()() As String()()
    Public Property slotArray() As Slotarray()
End Class

Public Class Slotarray
    Public Property objective As Objective
    Public Property incLevel As Single
    Public Property lottery() As Boolean()
End Class

Public Class Objective
    Public Property objectiveID As String
    Public Property requirements() As Requirement1()
    Public Property completed As Boolean
    Public Property incrementLevel As Single
End Class

Public Class Requirement1
    Public Property requirementID As String
    Public Property satisfied As Boolean
    Public Property currentIncidents As Single
    Public Property failedRequirement As Boolean
    Public Property acceptedRoom As Single
    Public Property currentEmergency As Single
End Class

Public Class Unlockablemgr
    Public Property objectivesInProgress() As Object()
    Public Property completed() As Object()
    Public Property claimed() As String()
End Class

Public Class Survivalw
    Public Property weapons() As String()
    Public Property outfits() As String()
    Public Property dwellers() As String()
    Public Property pets() As String()
    Public Property breeds() As String()
    Public Property decorations() As Object()
    Public Property junk() As String()
    Public Property recipes() As String()
    Public Property claimedRecipes() As String()
End Class

Public Class Happinessmanager
    Public Property rooms() As Single()
    Public Property dwellers() As Single()
End Class

'Public Class Room692
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room723
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room5297
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room682
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room687
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room5295
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room6361
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room7022
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room4761
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room5307
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room540
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room6626
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room12439
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Room12715
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'    Public Property dc As Single
'End Class

'Public Class Dweller5
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller64
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller15
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller14
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller4
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller10
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller9
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller8
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller7
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller18
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller29
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller19
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller31
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller39
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller38
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller40
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller45
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller47
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller43
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller30
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller50
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller52
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller54
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller56
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller60
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller61
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller51
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller27
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller16
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller21
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller59
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller67
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller68
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller70
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller77
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller76
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

'Public Class Dweller74
'    Public Property type As Single
'    Public Property rh As Single
'    Public Property _in As Boolean
'End Class

Public Class Refugeespawner
    Public Property newGameTask As Single
    Public Property succeed As Single
    Public Property currentPool As String
    Public Property collectedAllRefugees As Boolean
End Class

Public Class Deathclawmanager
    Public Property deathclawTotalExtraChance As Single
    Public Property canDeathclawEmergencyOccurs As Boolean
    Public Property deathclawCooldownID As Single
End Class

Public Class Mysteriousstranger
    Public Property currentState As String
    Public Property canAppear As Boolean
    Public Property timeToAppear As Single
    Public Property remainingTimeToAppear As Single
End Class

Public Class Statswindow
    Public Property vaultData As Vaultdata
End Class

Public Class Vaultdata
    Public Property collectedRes As Collectedres
    Public Property collectedOutfits As Single
    Public Property collectedWeapons As Single
    Public Property collectedDecorations As Single
    Public Property collectedPets As Single
    Public Property raidersKilled As Single
    Public Property elevatorRides As Single
    Public Property lunchBoxesOpened As Single
    Public Property petCarriersOpened As Single
    Public Property totalLifetimeDwellers As Single
    Public Property babiesBorn As Single
    Public Property dwellersRevived As Single
    Public Property levelsGained As Single
    Public Property specialStatTrained As Single
    Public Property takenStimpack As Single
    Public Property takenRadaway As Single
    Public Property deadDwellers As Single
    Public Property evictedDwellers As Single
    Public Property soldWeapons As Single
    Public Property soldOutfits As Single
    Public Property soldDecorations As Single
    Public Property soldPets As Single
    Public Property scrappedOutfits As Single
    Public Property scrappedWeapons As Single
    Public Property craftedWeapons As Single
    Public Property craftedOutfits As Single
    Public Property craftedDecorations As Single
    Public Property collectedJunk As Single
    Public Property soldJunk As Single
    Public Property successfulRushes As Single
    Public Property failRushes As Single
    Public Property firesExtinguised As Single
    Public Property emergencyStopRaider As Single
    Public Property emergencyStopDeathClaw As Single
    Public Property emergencyStopRadroach As Single
    Public Property emergencyStopMolerat As Single
    Public Property dwellersSentWasteland As Single
    Public Property wastelandTotalTime As Single
    Public Property wastelandCreaturesKilled As Single
    Public Property vaultCreatedBeforeUpdate As Boolean
    Public Property dwellersCustomized As Single
    Public Property measuringSince As Long
    Public Property previousVResources As Previousvresources
    Public Property weaponFactoryBuilt As Boolean
    Public Property outfitFactoryBuilt As Boolean
End Class

Public Class Collectedres
    Public Property Nuka As Single
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Single
    Public Property RadAway As Single
    Public Property Lunchbox As Single
    Public Property MrHandy As Single
    Public Property PetCarrier As Single
    Public Property CraftedOutfit As Single
    Public Property CraftedWeapon As Single
End Class

Public Class Previousvresources
    Public Property Nuka As Single
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Single
    Public Property RadAway As Single
    Public Property Lunchbox As Single
    Public Property MrHandy As Single
    Public Property PetCarrier As Single
    Public Property CraftedOutfit As Single
    Public Property CraftedWeapon As Single
End Class

Public Class Swrveeventsmanager
    'Public Property currentIncidentTypeInt As Single
    'Public Property currentIncidentModeInt As Single
    'Public Property initialDwellerCount As Single
    'Public Property deadDwellerCount As Single
    'Public Property initialFoodAmount As Single
    'Public Property initialPowerAmount As Single
    'Public Property initialWaterAmount As Single
    'Public Property vaultLastSentMsgHour As Single
    'Public Property alreadyBoughtRooms() As String()
    'Public Property alreadyUpgradedRoomsLvl2() As String()
    'Public Property alreadyUpgradedRoomsLvl3() As String()
    'Public Property hasSentFTBuyAnyRoom As Single
    'Public Property hasSentFTUpgradeLvl2AnyRoom As Single
    'Public Property hasSentFTUpgradeLvl3AnyRoom As Single
    'Public Property hasSentFTMerge2AnyRoom As Single
    'Public Property hasSentFTMerge3AnyRoom As Single
    'Public Property hasSentFTBabyFlirt As Single
    'Public Property hasSentFTBabyMakeBaby As Single
    'Public Property hasSentFTBabyBorn As Single
    'Public Property hasSentWastelandFTStartExplore As Single
    'Public Property hasSentWastelandFTDeadDweller As Single
    'Public Property hasSentWastelandFTReviveDweller As Single
    'Public Property hasSentWastelandFTRecall As Single
    'Public Property hasSentDwellerCount50 As Single
    'Public Property hasSentDwellerCount100 As Single
    'Public Property hasSentDwellerCount150 As Single
    'Public Property hasSentDwellerCount200 As Single
    'Public Property m_alreadyMergedRoomsLvl2() As String()
    'Public Property m_alreadyMergedRoomsLvl3() As String()
End Class
