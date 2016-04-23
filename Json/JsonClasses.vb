Public Class Rootobject
    Public Property timeMgr As Timemgr
    Public Property localNotificationMgr As Localnotificationmgr
    Public Property taskMgr As Taskmgr
    Public Property ratingMgr As Ratingmgr
    Public Property dwellers As Dwellers
    Public Property constructMgr As Constructmgr
    Public Property vault As Vault
    Public Property dwellerSpawner As Dwellerspawner
    Public Property deviceName As String
    Public Property tutorialManager As Tutorialmanager
    Public Property objectiveMgr As Objectivemgr
    Public Property unlockableMgr As Unlockablemgr
    Public Property survivalW As Survivalw
    Public Property happinessManager As Happinessmanager
    Public Property refugeeSpawner As Refugeespawner
    Public Property LunchBoxCollectWindow As Object
    Public Property DeathclawManager As Deathclawmanager
    Public Property PromoCodesWindow As Object
    Public Property JunkGiveAwayWindow As Object
    Public Property MysteriousStranger As Mysteriousstranger
    Public Property StatsWindow As Statswindow
    Public Property PromotionFlags() As String()
    Public Property appVersion As String
    Public Property swrveEventsManager As Swrveeventsmanager
    Public Property versionCount As Integer
End Class

Public Class Timemgr
    Public Property gameTime As Single
    Public Property time As Single
    Public Property timeSaveDate As Long
    Public Property timeGameBegin As Long
End Class

Public Class Localnotificationmgr
    Public Property UniqueIDS() As Integer()
    Public Property AndroidNotifications() As Object()
End Class

Public Class Taskmgr
    Public Property id As Integer
    Public Property time As Single
    Public Property tasks() As [Tasks]()
    Public Property pausedTasks() As Object
End Class

Public Class Tasks
    Public Property startTime As Single
    Public Property endTime As Single
    Public Property name As String
    Public Property id As Integer
    Public Property paused As Boolean
    Public Property rescheduleToOldest As Boolean
End Class

Public Class Ratingmgr
    Public Property sampleId As Integer
    Public Property dayRatingId As Integer
    Public Property currentSamples() As Integer()
    Public Property ratings() As Rating()
    Public Property ratingsLast() As Ratingslast()
    Public Property hasWeekRating As Boolean
    Public Property hasLastWeekRating As Boolean
    Public Property weekRating As Integer
    Public Property lastWeekRating As Integer
End Class

Public Class Rating
    Public Property rating As Integer
    Public Property time As Single
    Public Property collected As Boolean
End Class

Public Class Ratingslast
    Public Property rating As Integer
    Public Property time As Single
    Public Property collected As Boolean
End Class

Public Class Dwellers
    Public Property dwellers() As Dweller()
    Public Property actors() As Actor()
    Public Property id As Integer
    Public Property mrhId As Integer
    Public Property min_happiness As Integer
End Class

Public Class Dweller
    Public Property serializeId As Integer
    Public Property name As String
    Public Property lastName As String
    Public Property happiness As Happiness
    Public Property health As Health
    Public Property experience As Experience
    Public Property relations As Relations
    Public Property equipment As Equipment
    Public Property gender As Integer
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
    Public Property pendingExperienceReward As Integer
    Public Property uniqueData As String
    Public Property hair As String
    Public Property equipedOutfit As Equipedoutfit
    Public Property equipedWeapon As Equipedweapon
    Public Property equippedPet As Equippedpet
    Public Property savedRoom As Integer
    Public Property lastChildBorn As Integer
    Public Property rarity As String
    Public Property deathTime As Integer
    Public Property daysOnWasteland As Integer
    Public Property hoursOnWasteland As Integer
    Public Property faceMask As String
End Class

Public Class Happiness
    Public Property happinessValue As Integer
End Class

Public Class Health
    Public Property healthValue As Single
    Public Property radiationValue As Integer
    Public Property permaDeath As Boolean
    Public Property lastLevelUpdated As Integer
    Public Property maxHealth As Single
End Class

Public Class Experience
    Public Property experienceValue As Single
    Public Property currentLevel As Integer
    Public Property storage As Integer
    Public Property accum As Integer
    Public Property needLvUp As Boolean
    Public Property wastelandExperience As Integer
End Class

Public Class Relations
    Public Property relations() As Object()
    Public Property partner As Integer
    Public Property lastPartner As Integer
    Public Property ascendants() As Integer()
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
    Public Property Nuka As Integer
    Public Property Food As Integer
    Public Property Energy As Integer
    Public Property Water As Integer
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
End Class

Public Class Bonus
    Public Property Nuka As Integer
    Public Property Food As Integer
    Public Property Energy As Integer
    Public Property Water As Integer
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
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
    Public Property value As Integer
    Public Property _mod As Integer
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
    Public Property characterType As Integer
    Public Property actorDataId As String
    Public Property serializeId As Integer
    Public Property name As String
    Public Property canCollect As Boolean
    Public Property willGoToWasteland As Boolean
    Public Property equipment As Equipment1
    Public Property health As Single
    Public Property death As Boolean
    Public Property savedRoom As Integer
    Public Property FollowedID As Integer
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
    Public Property roomDeserializeID As Integer
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
    Public Property LunchBoxesByType() As Integer()
    Public Property LunchBoxesCount As Integer
    Public Property VaultName As String
    Public Property VaultMode As String
    Public Property VaultTheme As Integer
    Public Property Achievements As Achievements
    Public Property wasteland As Wasteland
End Class

Public Class Storage2
    Public Property resources As Resources2
    Public Property bonus As Bonus
End Class

Public Class Resources2
    Public Property Nuka As Integer
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
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
    Public Property bonusValue As Integer
End Class

Public Class Emergencydata
    Public Property active As Boolean
    Public Property randomEventTaskId As Integer
End Class

Public Class Roomconsumption
    Public Property taskIdOnline As Integer
    Public Property taskIDShutDown As Integer
End Class

Public Class Dwellerwaterconsumption
    Public Property taskIdOnline As Integer
End Class

Public Class Dwellerfoodconsumption
    Public Property taskIdOnline As Integer
End Class

Public Class Achievements
    Public Property objectivesInProgress() As Objectivesinprogress()
    Public Property completed() As String()
End Class

Public Class Objectivesinprogress
    Public Property objectiveID As String
    Public Property requirements() As Requirement()
    Public Property completed As Boolean
    Public Property incrementLevel As Integer
End Class

Public Class Requirement
    Public Property requirementID As String
    Public Property satisfied As Boolean
    Public Property rushCount As Integer
    Public Property higherMergeLevelFound As Integer
    Public Property currentBabies As Integer
    Public Property acceptedRoom As Integer
    Public Property currentInvasions As Integer
    Public Property numberOfObjectivesCompleted As Integer
    Public Property currentLegendaryDwellers As Integer
    Public Property currentLegendaryOutfits As Integer
    Public Property currentLegendaryWeapons As Integer
End Class

Public Class Wasteland
    Public Property state As State
    Public Property teams() As Team()
    Public Property cycles() As Cycle()
    Public Property mrHandyCycles() As Mrhandycycle()
    Public Property allTimeTeamsCounter As Integer
End Class

Public Class State
    Public Property name As String
End Class

Public Class Team
    Public Property dwellers() As Integer()
    Public Property returnTripDuration As Integer
    Public Property elapsedTimeAliveExploring As Integer
    Public Property elapsedReturningTime As Integer
    Public Property teamIndex As Integer
    Public Property status As String
    Public Property logs() As String()
    Public Property missedEncounters As Integer
    Public Property introMessages As Integer
    Public Property notificationID As Integer
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
    Public Property taskId As Integer
    Public Property pendingCycles() As Object()
    Public Property teamEncounters() As Teamencounter()
    Public Property inProgress() As Object()
End Class

Public Class Teamencounter
    Public Property teamEncounters() As Teamencounter1()
    Public Property teamID As Integer
End Class

Public Class Teamencounter1
    Public Property nonRepeatable() As String()
    Public Property poolType As String
End Class

Public Class Mrhandycycle
    Public Property cycleType As String
    Public Property taskId As Integer
End Class

Public Class Room
    Public Property emergencyDone As Boolean
    Public Property type As String
    Public Property _class As String
    Public Property mergeLevel As Integer
    Public Property row As Integer
    Public Property col As Integer
    Public Property power As Boolean
    Public Property roomHealth As Roomhealth
    Public Property mrHandyList() As Integer?()
    Public Property rushTask As Integer
    Public Property level As Integer
    Public Property dwellers() As Integer?()
    Public Property deadDwellers() As Object()
    Public Property currentStateName As String
    Public Property currentState As Currentstate
    Public Property deserializeID As Integer
    Public Property assignedDecoration As String
    Public Property broken As Boolean
    Public Property withHole As Boolean
    Public Property storage As Storage3
    Public Property numberOfProductionCycle As Integer
    Public Property ExperienceRewardIsDirty As Boolean
    Public Property slots() As Slot()
    Public Property dwellerWithPendingCompleteTraining() As Object()
    Public Property children() As Object()
    Public Property partners() As Object()
    Public Property IngredientItemIds() As Object()
    Public Property CraftingItemId As String
    Public Property CompletedTime As Integer
End Class

Public Class Roomhealth
    Public Property damageValue As Single
End Class

Public Class Currentstate
    Public Property taskId As Integer
    Public Property notificationId As String
End Class

Public Class Storage3
    Public Property resources As Resources3
    Public Property bonus As Bonus3
End Class

Public Class Resources3
    Public Property Nuka As Integer
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
End Class

Public Class Bonus3
    Public Property Nuka As Integer
    Public Property Food As Integer
    Public Property Energy As Integer
    Public Property Water As Integer
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
End Class

Public Class Slot
    Public Property needLvUp As Boolean
    Public Property dwellerID As Integer
    Public Property taskID As Integer
End Class

Public Class Dwellerspawner
    Public Property dwellersWaiting() As Object()
End Class

Public Class Tutorialmanager
    Public Property phase As String
    Public Property taskNumber As Integer
    Public Property objectivesTutorialMessage As Boolean
    Public Property lunchboxTutorialMessage As Boolean
    Public Property showingObjectiveTutorialMessage As Boolean
    Public Property showingLunchboxTutorialMessage As Boolean
    Public Property showWastelandMessageTime As Integer
    Public Property showExploreWastelandMessageTime As Integer
    Public Property exploreWastelandMessageShown As Boolean
    Public Property skippedTutorial As Integer
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
    Public Property MaleTasksQuant As Integer
    Public Property FemaleTasksQuant As Integer
End Class

Public Class Objectivemgr
    Public Property taskID As Integer
    Public Property canDiscard As Boolean
    Public Property shuffleBags()() As String()()
    Public Property slotArray() As Slotarray()
End Class

Public Class Slotarray
    Public Property objective As Objective
    Public Property incLevel As Integer
    Public Property lottery() As Boolean()
End Class

Public Class Objective
    Public Property objectiveID As String
    Public Property requirements() As Requirement1()
    Public Property completed As Boolean
    Public Property incrementLevel As Integer
End Class

Public Class Requirement1
    Public Property requirementID As String
    Public Property satisfied As Boolean
    Public Property currentIncidents As Integer
    Public Property failedRequirement As Boolean
    Public Property acceptedRoom As Integer
    Public Property currentEmergency As Integer
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
    'Public Property room692() As Room692
    'Public Property room723() As Room723
    'Public Property room5297() As Room5297
    'Public Property room682() As Room682
    'Public Property room687() As Room687
    'Public Property room5295() As Room5295
    'Public Property room6361() As Room6361
    'Public Property room7022() As Room7022
    'Public Property room4761() As Room4761
    'Public Property room5307() As Room5307
    'Public Property room540() As Room540
    'Public Property room6626() As Room6626
    'Public Property room12439() As Room12439
    'Public Property room12715() As Room12715
    Public Property rooms() As Integer()
    'Public Property dweller5() As Dweller5
    'Public Property dweller64() As Dweller64
    'Public Property dweller15() As Dweller15
    'Public Property dweller14() As Dweller14
    'Public Property dweller4() As Dweller4
    'Public Property dweller10() As Dweller10
    'Public Property dweller9() As Dweller9
    'Public Property dweller8() As Dweller8
    'Public Property dweller7() As Dweller7
    'Public Property dweller18() As Dweller18
    'Public Property dweller29() As Dweller29
    'Public Property dweller19() As Dweller19
    'Public Property dweller31() As Dweller31
    'Public Property dweller39() As Dweller39
    'Public Property dweller38() As Dweller38
    'Public Property dweller40() As Dweller40
    'Public Property dweller45() As Dweller45
    'Public Property dweller47() As Dweller47
    'Public Property dweller43() As Dweller43
    'Public Property dweller30() As Dweller30
    'Public Property dweller50() As Dweller50
    'Public Property dweller52() As Dweller52
    'Public Property dweller54() As Dweller54
    'Public Property dweller56() As Dweller56
    'Public Property dweller60() As Dweller60
    'Public Property dweller61() As Dweller61
    'Public Property dweller51() As Dweller51
    'Public Property dweller27() As Dweller27
    'Public Property dweller16() As Dweller16
    'Public Property dweller21() As Dweller21
    'Public Property dweller59() As Dweller59
    'Public Property dweller67() As Dweller67
    'Public Property dweller68() As Dweller68
    'Public Property dweller70() As Dweller70
    'Public Property dweller77() As Dweller77
    'Public Property dweller76() As Dweller76
    'Public Property dweller74() As Dweller74
    Public Property dwellers() As Integer()
End Class

'Public Class Room692
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room723
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room5297
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room682
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room687
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room5295
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room6361
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room7022
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room4761
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room5307
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room540
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room6626
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room12439
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Room12715
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'    Public Property dc As Integer
'End Class

'Public Class Dweller5
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller64
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller15
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller14
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller4
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller10
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller9
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller8
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller7
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller18
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller29
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller19
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller31
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller39
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller38
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller40
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller45
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller47
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller43
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller30
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller50
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller52
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller54
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller56
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller60
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller61
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller51
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller27
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller16
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller21
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller59
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller67
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller68
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller70
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller77
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller76
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

'Public Class Dweller74
'    Public Property type As Integer
'    Public Property rh As Integer
'    Public Property _in As Boolean
'End Class

Public Class Refugeespawner
    Public Property newGameTask As Integer
    Public Property succeed As Integer
    Public Property currentPool As String
    Public Property collectedAllRefugees As Boolean
End Class

Public Class Deathclawmanager
    Public Property deathclawTotalExtraChance As Integer
    Public Property canDeathclawEmergencyOccurs As Boolean
    Public Property deathclawCooldownID As Integer
End Class

Public Class Mysteriousstranger
    Public Property currentState As String
    Public Property canAppear As Boolean
    Public Property timeToAppear As Single
    Public Property remainingTimeToAppear As Integer
End Class

Public Class Statswindow
    Public Property vaultData As Vaultdata
End Class

Public Class Vaultdata
    Public Property collectedRes As Collectedres
    Public Property collectedOutfits As Integer
    Public Property collectedWeapons As Integer
    Public Property collectedDecorations As Integer
    Public Property collectedPets As Integer
    Public Property raidersKilled As Integer
    Public Property elevatorRides As Integer
    Public Property lunchBoxesOpened As Integer
    Public Property petCarriersOpened As Integer
    Public Property totalLifetimeDwellers As Integer
    Public Property babiesBorn As Integer
    Public Property dwellersRevived As Integer
    Public Property levelsGained As Integer
    Public Property specialStatTrained As Integer
    Public Property takenStimpack As Integer
    Public Property takenRadaway As Integer
    Public Property deadDwellers As Integer
    Public Property evictedDwellers As Integer
    Public Property soldWeapons As Integer
    Public Property soldOutfits As Integer
    Public Property soldDecorations As Integer
    Public Property soldPets As Integer
    Public Property scrappedOutfits As Integer
    Public Property scrappedWeapons As Integer
    Public Property craftedWeapons As Integer
    Public Property craftedOutfits As Integer
    Public Property craftedDecorations As Integer
    Public Property collectedJunk As Integer
    Public Property soldJunk As Integer
    Public Property successfulRushes As Integer
    Public Property failRushes As Integer
    Public Property firesExtinguised As Integer
    Public Property emergencyStopRaider As Integer
    Public Property emergencyStopDeathClaw As Integer
    Public Property emergencyStopRadroach As Integer
    Public Property emergencyStopMolerat As Integer
    Public Property dwellersSentWasteland As Integer
    Public Property wastelandTotalTime As Integer
    Public Property wastelandCreaturesKilled As Integer
    Public Property vaultCreatedBeforeUpdate As Boolean
    Public Property dwellersCustomized As Integer
    Public Property measuringSince As Long
    Public Property previousVResources As Previousvresources
    Public Property weaponFactoryBuilt As Boolean
    Public Property outfitFactoryBuilt As Boolean
End Class

Public Class Collectedres
    Public Property Nuka As Integer
    Public Property Food As Integer
    Public Property Energy As Integer
    Public Property Water As Integer
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
End Class

Public Class Previousvresources
    Public Property Nuka As Integer
    Public Property Food As Single
    Public Property Energy As Single
    Public Property Water As Single
    Public Property StimPack As Integer
    Public Property RadAway As Integer
    Public Property Lunchbox As Integer
    Public Property MrHandy As Integer
    Public Property PetCarrier As Integer
    Public Property CraftedOutfit As Integer
    Public Property CraftedWeapon As Integer
End Class

Public Class Swrveeventsmanager
    Public Property currentIncidentTypeInt As Integer
    Public Property currentIncidentModeInt As Integer
    Public Property initialDwellerCount As Integer
    Public Property deadDwellerCount As Integer
    Public Property initialFoodAmount As Integer
    Public Property initialPowerAmount As Integer
    Public Property initialWaterAmount As Integer
    Public Property vaultLastSentMsgHour As Integer
    Public Property alreadyBoughtRooms() As String()
    Public Property alreadyUpgradedRoomsLvl2() As String()
    Public Property alreadyUpgradedRoomsLvl3() As String()
    Public Property hasSentFTBuyAnyRoom As Integer
    Public Property hasSentFTUpgradeLvl2AnyRoom As Integer
    Public Property hasSentFTUpgradeLvl3AnyRoom As Integer
    Public Property hasSentFTMerge2AnyRoom As Integer
    Public Property hasSentFTMerge3AnyRoom As Integer
    Public Property hasSentFTBabyFlirt As Integer
    Public Property hasSentFTBabyMakeBaby As Integer
    Public Property hasSentFTBabyBorn As Integer
    Public Property hasSentWastelandFTStartExplore As Integer
    Public Property hasSentWastelandFTDeadDweller As Integer
    Public Property hasSentWastelandFTReviveDweller As Integer
    Public Property hasSentWastelandFTRecall As Integer
    Public Property hasSentDwellerCount50 As Integer
    Public Property hasSentDwellerCount100 As Integer
    Public Property hasSentDwellerCount150 As Integer
    Public Property hasSentDwellerCount200 As Integer
    Public Property m_alreadyMergedRoomsLvl2() As String()
    Public Property m_alreadyMergedRoomsLvl3() As String()
End Class
