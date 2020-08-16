using System.Xml.Serialization;

namespace Models
{
    public enum RecordType
    {
        [XmlEnum("HKQuantityTypeIdentifierStepCount")]
        HKQuantityTypeIdentifierStepCount,
        [XmlEnum("HKQuantityTypeIdentifierDistanceWalkingRunning")]
        HKQuantityTypeIdentifierDistanceWalkingRunning,
        [XmlEnum("HKQuantityTypeIdentifierDistanceCycling")]
        HKQuantityTypeIdentifierDistanceCycling,
        [XmlEnum("HKQuantityTypeIdentifierPushCount")]
        HKQuantityTypeIdentifierPushCount,
        [XmlEnum("HKQuantityTypeIdentifierDistanceWheelchair")]
        HKQuantityTypeIdentifierDistanceWheelchair,
        [XmlEnum("HKQuantityTypeIdentifierSwimmingStrokeCount")]
        HKQuantityTypeIdentifierSwimmingStrokeCount,
        [XmlEnum("HKQuantityTypeIdentifierDistanceSwimming")]
        HKQuantityTypeIdentifierDistanceSwimming,
        [XmlEnum("HKQuantityTypeIdentifierDistanceDownhillSnowSports")]
        HKQuantityTypeIdentifierDistanceDownhillSnowSports,
        [XmlEnum("HKQuantityTypeIdentifierBasalEnergyBurned")]
        HKQuantityTypeIdentifierBasalEnergyBurned,
        [XmlEnum("HKQuantityTypeIdentifierActiveEnergyBurned")]
        HKQuantityTypeIdentifierActiveEnergyBurned,
        [XmlEnum("HKQuantityTypeIdentifierFlightsClimbed")]
        HKQuantityTypeIdentifierFlightsClimbed,
        [XmlEnum("HKQuantityTypeIdentifierNikeFuel")]
        HKQuantityTypeIdentifierNikeFuel,
        [XmlEnum("HKQuantityTypeIdentifierAppleExerciseTime")]
        HKQuantityTypeIdentifierAppleExerciseTime,
        [XmlEnum("HKCategoryTypeIdentifierAppleStandHour")]
        HKCategoryTypeIdentifierAppleStandHour,
        [XmlEnum("HKQuantityTypeIdentifierAppleStandTime")]
        HKQuantityTypeIdentifierAppleStandTime,
        [XmlEnum("HKCategoryTypeIdentifierSleepAnalysis")]
        HKCategoryTypeIdentifierSleepAnalysis
    }
}