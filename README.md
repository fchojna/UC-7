
# Use Case #7
Use Case #7 for SoftServe's statistical research on the impact of AI use on working performance.
## Documentation

1. **`StudentConverterTests`**
- **`ConvertStudents_StudentAgeAbove21GradeAbove90_HonorRollIsTrue`** - ensures that student with grade over 90 has `HonorRoll` property set to `True`.
- **`ConvertStudents_AgeBelow21GradeAbove90_ExceptionalIsTrue` - ensures that young student (below 21 years old) with grade over 90 has `Exceptional` property set to `True`.
- **`ConvertStudents_GradeBetween71And90_PassedIsTrue`** - ensures that student with grade between 71 and 90 has `Passed` property set to `True`.
- **`ConvertStudents_GradeBelow71_PassedIsFalse`** - ensures that student with grade below 71 has `Passed` property set to `False`.
- **`ConvertStudents_EmptyArrayPassed_ReturnsEmptyArray`** - ensures that passing empty array to the function results empty array return.
- **`ConvertStudents_NullPassed_ThrowsException`** - ensures that passing null to the function results with exception throw.

2. **`PlayerAnalyzerTests`**
- **`CalculateScore_SinglePlayerPassed_ScoreOfPlayerIsReturned`** - ensures that single player score is calculated properly by the function.
- **`CalculateScore_MultiplePlayersPassed_SumOfPassedPlayersIsReturned`** - ensures that passing multiple player results with return of proper sum of all passed player scores.
- **`CalculateScore_SkillEqualsNull_ThrowsException`** - ensures that passing player with null skill to the function results with exception throw.
- **`CalculateScore_EmptyArrayPassed_ScoreEquals0`** - ensures that passing empty array to the function results with return of score equal 0.


## Running Tests

To run tests locally, run the following command in solution directory

```bash
  dotnet test
```

