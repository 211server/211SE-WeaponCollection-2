<?xml version="1.0"?>
<Definitions xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <EmissiveColorStatePresets>
    <!--
    Blocks use these states:
      Working - block is functional
      Disabled - block has no power or is not enabled
      Damaged - block is not functional (damaged)
      Warning - used by some blocks to when the block is not working correctly (for example used by vent when the room is not presurized)
      Alternative - used by some blocks that it is working in different way than default one (for example used by vent when depressurizing)
      Locked - Used by connector type blocks when they are locked with each other
      Autolock - Used by landing gear
      Constraint - Used by connector type block when they are close enough and are not locked
    -->
    
    <EmissiveColorStatePreset>
      <Id>
        <TypeId>MyObjectBuilder_EmissiveColorStatePresetDefinition</TypeId>
        <SubtypeId>MWI_Cannons</SubtypeId>
      </Id>
      <EmissiveStates>
        <EmissiveState StateName="Damaged" EmissiveColorName="Red" DisplayColorName="Red" Emissivity="0" />
        <EmissiveState StateName="Disabled" EmissiveColorName="Red" DisplayColorName="White" Emissivity="1" />
        <EmissiveState StateName="Working" EmissiveColorName="Cyan" DisplayColorName="White" Emissivity="1" />
      </EmissiveStates>
    </EmissiveColorStatePreset>
	
</EmissiveColorStatePresets>
</Definitions>
