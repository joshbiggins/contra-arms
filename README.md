# Contra Arms
This is a sample project that replicates the "ball-and-chain" limbs found in every 16-bit run-n-gun game (hence the project title).
How to use:
The two objects found in test scene, "ArmStart" and "ArmEnd", represent the start and end of the limb, respectively.

-To move the arm end around, simply click and drag around the screen.
-To switch between a fixed chain (will follow normal gravity, used for things like hanging objects) or a flexible chain (will bend around as the arm moves), select the ArmEnd object and change the "ArmPiece" parameter to the "ArmPiece" prefab. To change back to a fixed chain, switch the parameter to the "FixedArmPiece" prefab.
-To change how steep of a bend the chain has (when using a flexible chain), adjust the "Bend" parameter on the ArmEnd.
