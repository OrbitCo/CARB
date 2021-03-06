// @flow

import React from 'react';
import { DropDownList, MultiSelect } from '@progress/kendo-react-dropdowns';
import { Input } from '@progress/kendo-react-inputs';
import { DatePicker } from '@progress/kendo-react-dateinputs';
// components
import InfoTooltip from 'components/InfoTooltip';
// styled components
import { InputGroup, Label, Unit } from './StyledComponents';
// mock data (TEMP)
import {
  communityNames,
  monitorPurpose,
  monitorManufacturer,
  monitorModel,
  monitorParameters,
  parameterMeasurementTechnique,
  parameterMeasurementUnits,
  parameterSamplingDuration,
  parameterUpperDetectionLimit,
  parameterLowerDetectionLimit,
  parameterMethodDetectionLimit,
  parameterDetectionRangeUnits,
  parameterUncertainty,
  parameterMeasurementResolution,
} from './mockData';

export const CommunityName = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="communityName">
      Community Name / Project Name
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="communityName"
      name="communityName"
      defaultValue={defaultValue}
      data={communityNames} // TODO: pull from web service
      validationMessage="Please select a Community or Project Name."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteName = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="Site Name will be displayed on the map." />
    <Label htmlFor="siteName">
      Site Name
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="siteName"
      name="siteName"
      defaultValue={defaultValue}
      pattern={'[A-Za-z0-9_ ]+'}
      validationMessage="Site Name can only contain letters, numbers, spaces, and underscores."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteNameSelect = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  data = [],
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="Site Name will be displayed on the map." />
    <Label htmlFor="siteName">
      Site Name
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="siteName"
      name="siteName"
      defaultValue={defaultValue}
      data={data}
      validationMessage="Please select a Site Name."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteId = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="siteId">
      Site ID
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="siteId"
      name="siteId"
      defaultValue={defaultValue}
      pattern={'[A-Za-z0-9_-]+'}
      validationMessage="Site ID can only contain letters, numbers, hyphens, and underscores."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteIdSelect = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  data = [],
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="Site Name will be displayed on the map." />
    <Label htmlFor="siteId">
      Site ID
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="siteId"
      name="siteId"
      defaultValue={defaultValue}
      data={data}
      validationMessage="Please select a Site ID."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteLatitude = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="siteLatitude">
      Latitude
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="siteLatitude"
      name="siteLatitude"
      defaultValue={defaultValue}
      pattern={'[0-9]+.[0-9]{4,7}'}
      validationMessage="Latitude must be a number, and must include between four and seven digits after the decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteLongitude = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="siteLongitude">
      Longitude
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="siteLongitude"
      name="siteLongitude"
      defaultValue={defaultValue}
      pattern={'-[0-9]+.[0-9]{4,7}'}
      validationMessage="Longitude must be a negative number, and must include between four and seven digits after the decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const SiteElevation = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="siteElevation">
      Elevation
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="siteElevation"
      name="siteElevation"
      defaultValue={defaultValue}
      pattern={'[0-9]+(?:.?[0-9]+)?'}
      validationMessage="Elevation must be a number, with an optional decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
    <Unit>meters</Unit>
  </InputGroup>
);

export const MonitorCfrSiting = ({
  defaultValue = 'No',
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="Does the monitor follows CFR guidelines?" />
    <Label htmlFor="monitorCfrSiting">
      CFR Siting
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="monitorCfrSiting"
      name="monitorCfrSiting"
      defaultValue={defaultValue}
      data={['Yes', 'No']}
      validationMessage="Please select a value for CFR Siting."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorPurpose = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorPurpose">
      Monitor Purpose
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="monitorPurpose"
      name="monitorPurpose"
      defaultValue={defaultValue}
      data={monitorPurpose} // TODO: pull from web service
      validationMessage="Please select a Monitor Purpose."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorId = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorId">
      Monitor ID
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorId"
      name="monitorId"
      defaultValue={defaultValue}
      pattern={'[A-Za-z0-9_-]+'}
      validationMessage="Monitor ID can only contain letters, numbers, hyphens, and underscores."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorManufacturer = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorManufacturer">
      Monitor Manufacturer
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="monitorManufacturer"
      name="monitorManufacturer"
      defaultValue={defaultValue}
      data={monitorManufacturer} // TODO: pull from web service
      validationMessage="Please select a Manufacturer."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorModel = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorModel">
      Monitor Model
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="monitorModel"
      name="monitorModel"
      defaultValue={defaultValue}
      data={monitorModel} // TODO: pull from web service
      validationMessage="Please select a Model."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorFirmwareVersion = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorFirmwareVersion">
      Firmware Version
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorFirmwareVersion"
      name="monitorFirmwareVersion"
      defaultValue={defaultValue}
      pattern={'[A-Za-z0-9_ ]+'}
      validationMessage="Firmware Version can only contain letters, numbers, spaces, and underscores."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorParameters = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="Select parameters this monitor will capture. Additional fields will be displayed for each selected parameter below." />
    <Label htmlFor="monitorParameters">
      Parameters
      {required && <span className="k-required">*</span>}
    </Label>
    <MultiSelect
      id="monitorParameters"
      // name="monitorParameters"
      defaultValue={defaultValue}
      dataItemKey={'parameterCode'}
      textField={'parameterName'}
      itemRender={(li, itemProps) => {
        const children = (
          <>
            {li.props.children /* parameter name */}
            &nbsp;
            <small>({itemProps.dataItem.parameterCode})</small>
          </>
        );
        return React.cloneElement(li, li.props, children);
      }}
      tagRender={(tagData, li) => {
        const children = (
          <>
            {li.props.children[0] /* parameter name */}
            &nbsp;
            <small>({tagData.data[0].parameterCode})</small>
            {li.props.children[1] /* close icon */}
          </>
        );
        return React.cloneElement(li, li.props, children);
      }}
      data={monitorParameters} // TODO: pull from web service
      validationMessage="Please select at least one Parameter."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterMeasurementTechnique = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterMeasurementTechnique">
      Measurement Technique
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterMeasurementTechnique"
      name="parameterMeasurementTechnique"
      defaultValue={defaultValue}
      data={parameterMeasurementTechnique} // TODO: pull from web service
      validationMessage="Please select a Measurement Technique."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterMeasurementUnits = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterMeasurementUnits">
      Measurement Units
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterMeasurementUnits"
      name="parameterMeasurementUnits"
      defaultValue={defaultValue}
      data={parameterMeasurementUnits} // TODO: pull from web service
      validationMessage="Please select a Measurement Unit."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterSamplingFrequency = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterSamplingFrequency">
      Sampling Frequency
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="parameterSamplingFrequency"
      name="parameterSamplingFrequency"
      defaultValue={defaultValue}
      pattern={'[0-9]+[smhd]'}
      validationMessage="Sampling Frequency must begin with a number, and be followed by one of the following letters: s, m, h, d."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterSamplingDuration = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterSamplingDuration">
      Sampling Duration
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterSamplingDuration"
      name="parameterSamplingDuration"
      defaultValue={defaultValue}
      data={parameterSamplingDuration} // TODO: pull from web service
      validationMessage="Please select a Sampling Duration."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterUpperDetectionLimit = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterUpperDetectionLimit">
      Upper Detection Limit
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterUpperDetectionLimit"
      name="parameterUpperDetectionLimit"
      defaultValue={defaultValue}
      data={parameterUpperDetectionLimit} // TODO: pull from web service
      validationMessage="Please select an Upper Detection Limit."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterLowerDetectionLimit = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterLowerDetectionLimit">
      Lower Detection Limit
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterLowerDetectionLimit"
      name="parameterLowerDetectionLimit"
      defaultValue={defaultValue}
      data={parameterLowerDetectionLimit} // TODO: pull from web service
      validationMessage="Please select a Lower Detection Limit."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterMethodDetectionLimit = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterMethodDetectionLimit">
      Method Detection Limit
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterMethodDetectionLimit"
      name="parameterMethodDetectionLimit"
      defaultValue={defaultValue}
      data={parameterMethodDetectionLimit} // TODO: pull from web service
      validationMessage="Please select a Method Detection Limit."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterDetectionRangeUnits = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterDetectionRangeUnits">
      Detection Range Units
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterDetectionRangeUnits"
      name="parameterDetectionRangeUnits"
      defaultValue={defaultValue}
      data={parameterDetectionRangeUnits} // TODO: pull from web service
      validationMessage="Please select Detection Range Units."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterUncertainty = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterUncertainty">
      Monitor Uncertainty
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterUncertainty"
      name="parameterUncertainty"
      defaultValue={defaultValue}
      data={parameterUncertainty} // TODO: pull from web service
      validationMessage="Please select Monitor Uncertainty."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterPrecision = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterPrecision">
      Precision
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="parameterPrecision"
      name="parameterPrecision"
      defaultValue={defaultValue}
      // pattern={'[A-Za-z0-9_ ]+'} // TODO: restrict certain special characters?
      validationMessage="Precision can contain letters, numbers, and special characters."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export class MonitorSystemDescription extends React.Component {
  state = {
    valid: true,
  };

  static defaultProps = {
    defaultValue: null,
    required: false,
    disabled: false,
  };

  validateTextarea = (value) => {
    this.setState((state, props) => {
      if (!props.required) return;
      return { valid: value !== '' };
    });
  };

  componentDidMount() {
    this.validateTextarea(this.textarea.value);
  }

  render() {
    const { defaultValue, required, disabled, onChange, ...props } = this.props;
    const { valid } = this.state;

    return (
      <InputGroup>
        <InfoTooltip text="..." />
        <Label htmlFor="monitorSystemDescription">
          System Description
          {required && <span className="k-required">*</span>}
        </Label>
        <textarea
          ref={(el) => (this.textarea = el)}
          id="monitorSystemDescription"
          name="monitorSystemDescription"
          defaultValue={defaultValue}
          className={`k-textarea ${!valid && 'k-state-invalid'}`}
          required={required}
          disabled={disabled}
          onChange={(ev) => {
            this.validateTextarea(ev.target.value);
            // lift onChange event up, in case user of component needs it
            onChange && onChange(ev);
          }}
          {...props}
        />
      </InputGroup>
    );
  }
}

export const MonitorPurchaseDate = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorPurchaseDate">
      Purchase Date
      {required && <span className="k-required">*</span>}
    </Label>
    <DatePicker
      id="monitorPurchaseDate"
      name="monitorPurchaseDate"
      defaultValue={defaultValue}
      format={'MM/dd/yyyy'}
      formatPlaceholder={{
        day: 'DD',
        month: 'MM',
        year: 'YYYY',
        hour: 'HH',
        minute: 'MM',
        second: 'SS',
      }}
      validationMessage="Please select Monitor Purchase Date."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterLastCalibrationTimestamp = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterLastCalibrationTimestamp">
      Last Calibration Timestamp
      {required && <span className="k-required">*</span>}
    </Label>
    <DatePicker
      id="parameterLastCalibrationTimestamp"
      name="parameterLastCalibrationTimestamp"
      defaultValue={defaultValue}
      format={'MM/dd/yyyy HH:mm:ss'}
      formatPlaceholder={{
        day: 'DD',
        month: 'MM',
        year: 'YYYY',
        hour: 'HH',
        minute: 'MM',
        second: 'SS',
      }}
      validationMessage="Please select Timestamp of Monitor’s Last Calibration."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorLastServiceDate = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorLastServiceDate">
      Last Service Date
      {required && <span className="k-required">*</span>}
    </Label>
    <DatePicker
      id="monitorLastServiceDate"
      name="monitorLastServiceDate"
      defaultValue={defaultValue}
      format={'MM/dd/yyyy'}
      formatPlaceholder={{
        day: 'DD',
        month: 'MM',
        year: 'YYYY',
        hour: 'HH',
        minute: 'MM',
        second: 'SS',
      }}
      validationMessage="Please select Monitor’s Last Service Date."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorInletOrientation = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorInletOrientation">
      Inlet Orientation
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorInletOrientation"
      name="monitorInletOrientation"
      defaultValue={defaultValue}
      pattern={'[0-9]+(?:.?[0-9]+)?'}
      validationMessage="Inlet Orientation must be a number, with an optional decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorInletHeight = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorInletHeight">
      Inlet Height
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorInletHeight"
      name="monitorInletHeight"
      defaultValue={defaultValue}
      pattern={'[0-9]+(?:.?[0-9]+)?'}
      validationMessage="Inlet Height must be a number, with an optional decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorInletDiameter = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorInletDiameter">
      Inlet Diameter
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorInletDiameter"
      name="monitorInletDiameter"
      defaultValue={defaultValue}
      pattern={'[0-9]+(?:.?[0-9]+)?'}
      validationMessage="Inlet Diameter must be a number, with an optional decimal."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const MonitorFlowRate = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="monitorFlowRate">
      Flow Rate
      {required && <span className="k-required">*</span>}
    </Label>
    <Input
      id="monitorFlowRate"
      name="monitorFlowRate"
      defaultValue={defaultValue}
      // pattern={'[A-Za-z0-9_ ]+'} // TODO: restrict certain special characters?
      validationMessage="Flow Rate can contain letters, numbers, and special characters."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const ParameterMeasurementResolution = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="parameterMeasurementResolution">
      Measurement Resolution
      {required && <span className="k-required">*</span>}
    </Label>
    <DropDownList
      id="parameterMeasurementResolution"
      name="parameterMeasurementResolution"
      defaultValue={defaultValue}
      data={parameterMeasurementResolution} // TODO: pull from web service
      validationMessage="Please select Measurement Resolution."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export class Explanation extends React.Component {
  state = {
    valid: true,
  };

  static defaultProps = {
    defaultValue: null,
    required: false,
    disabled: false,
  };

  validateTextarea = (value) => {
    this.setState((state, props) => {
      if (!props.required) return;
      return { valid: value !== '' };
    });
  };

  componentDidMount() {
    this.validateTextarea(this.textarea.value);
  }

  render() {
    const { defaultValue, required, disabled, onChange, ...props } = this.props;
    const { valid } = this.state;

    return (
      <InputGroup>
        <InfoTooltip text="..." />
        <Label htmlFor="explanation">
          Explanation
          {required && <span className="k-required">*</span>}
        </Label>
        <textarea
          ref={(el) => (this.textarea = el)}
          id="explanation"
          name="explanation"
          defaultValue={defaultValue}
          className={`k-textarea ${!valid && 'k-state-invalid'}`}
          required={required}
          disabled={disabled}
          onChange={(ev) => {
            this.validateTextarea(ev.target.value);
            // lift onChange event up, in case user of component needs it
            onChange && onChange(ev);
          }}
          {...props}
        />
      </InputGroup>
    );
  }
}

export const DateStart = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="dateStart">
      Start Date
      {required && <span className="k-required">*</span>}
    </Label>
    <DatePicker
      id="dateStart"
      name="dateStart"
      defaultValue={defaultValue}
      format={'MM/dd/yyyy'}
      formatPlaceholder={{
        day: 'DD',
        month: 'MM',
        year: 'YYYY',
        hour: 'HH',
        minute: 'MM',
        second: 'SS',
      }}
      validationMessage="Please select a Start Date."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);

export const DateEnd = ({
  defaultValue = null,
  validityStyles = true,
  required = false,
  disabled = false,
  ...props
}) => (
  <InputGroup>
    <InfoTooltip text="..." />
    <Label htmlFor="dateEnd">
      End Date
      {required && <span className="k-required">*</span>}
    </Label>
    <DatePicker
      id="dateEnd"
      name="dateEnd"
      defaultValue={defaultValue}
      format={'MM/dd/yyyy'}
      formatPlaceholder={{
        day: 'DD',
        month: 'MM',
        year: 'YYYY',
        hour: 'HH',
        minute: 'MM',
        second: 'SS',
      }}
      validationMessage="Please select an End Date."
      validityStyles={validityStyles}
      required={required}
      disabled={disabled}
      {...props}
    />
  </InputGroup>
);
