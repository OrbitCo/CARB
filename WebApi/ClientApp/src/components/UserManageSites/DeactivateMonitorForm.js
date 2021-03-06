// @flow

import React from 'react';
// components
import {
  CommunityName,
  SiteName,
  SiteId,
  SiteLatitude,
  SiteLongitude,
  SiteElevation,
  MonitorId,
  MonitorPurpose,
  MonitorManufacturer,
  MonitorModel,
  MonitorFirmwareVersion,
  MonitorPurchaseDate,
  MonitorLastServiceDate,
  MonitorParameters,
  ParameterMeasurementTechnique,
  ParameterMeasurementUnits,
  ParameterSamplingDuration,
  ParameterSamplingFrequency,
  ParameterDetectionRangeUnits,
  ParameterUpperDetectionLimit,
  ParameterLowerDetectionLimit,
  ParameterMethodDetectionLimit,
  ParameterUncertainty,
  ParameterPrecision,
  ParameterMeasurementResolution,
  ParameterLastCalibrationTimestamp,
  DateEnd,
  MonitorCfrSiting,
  MonitorFlowRate,
  MonitorInletHeight,
  MonitorInletOrientation,
  MonitorInletDiameter,
  MonitorSystemDescription,
  Explanation,
} from 'components/User/FormFields';
// styled components
import {
  Heading3,
  Form,
  FormButton,
  Row,
  RowHeader,
  RowContent,
  RowHeading,
} from 'components/User/StyledComponents';

// --- components ---
type Props = {
  site: Object,
  monitorId: string,
  onFieldsSubmit: (any) => void,
};

type State = {
  monitor: Object,
};

class UpdateMonitorForm extends React.Component<Props, State> {
  state: State = {
    monitor: null,
  };

  updateMonitorParams = (params) => {
    const monitor = { ...this.state.monitor };
    monitor.monitorParameters = params;
    this.setState({ monitor });
  };

  validateFields = (ev) => {
    ev.preventDefault();
    if (!this.form.checkValidity()) {
      this.form.reportValidity();
      return;
    }
    this.submitData();
  };

  submitData = () => {
    const fields = {
      _transactionType: 'DM',
      monitorParameters: [],
    };

    // array used to differentiate monitor fields and param fields
    const allParamFields = [];

    // build up array of params fieldsets by examining each form element's data attributes
    const paramsFieldsets = [];
    [...this.form.elements].forEach((el) => {
      if (el.dataset.monitorParams) paramsFieldsets.push(el);
    });

    // add params to fields object
    paramsFieldsets.forEach((paramsFieldset, paramsIndex) => {
      const p = this.state.monitor.monitorParameters[paramsIndex];
      const { parameterCode, parameterName } = p;

      // build up parameter object with each param field's name and value
      const parameter = { parameterCode, parameterName };

      [...paramsFieldset.elements].forEach((el) => {
        // ignore form elements without a name attribute
        if (!el.name) return;
        allParamFields.push(el);
        parameter[el.name] = el.value;
      });

      fields.monitorParameters.push(parameter);
    });

    // add all non-param fields to the fields object
    [...this.form.elements].forEach((el) => {
      // ignore form elements without a name attribute
      if (!el.name) return;
      // ensure field isn't a param field, which were all added previously
      if (allParamFields.indexOf(el) !== -1) return;
      fields[el.name] = el.value;
    });

    // pass fields up to parent component to be handled
    this.props.onFieldsSubmit(fields);
  };

  componentDidMount() {
    // initialize 'monitor' state from 'site' and 'monitorId' props
    const { site, monitorId } = this.props;
    const monitor = site.siteMonitors.filter(
      (m) => m.monitorId === monitorId,
    )[0];
    this.setState({ monitor });
  }

  render() {
    const { site } = this.props;
    const { monitor } = this.state;

    if (!monitor) return null;

    return (
      <div className="container">
        <Form ref={(el) => (this.form = el)}>
          <div className="row">
            <div className="col-md-4">
              <CommunityName
                defaultValue={site.communityProjectName}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <SiteName
                defaultValue={site.siteName}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <SiteId
                defaultValue={site.siteId}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <SiteLatitude
                defaultValue={site.siteLatitude}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <SiteLongitude
                defaultValue={site.siteLongitude}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <SiteElevation
                defaultValue={site.siteElevation}
                required={true}
                disabled={true}
              />
            </div>
          </div>

          <div className="row">
            <div className="col-sm-12">
              <Heading3>Monitor Specs</Heading3>
            </div>

            <div className="col-md-6">
              <MonitorId
                defaultValue={monitor.monitorId}
                required={true}
                disabled={true}
              />
            </div>

            <div className="col-md-6">
              <MonitorPurpose
                defaultValue={monitor.monitorPurpose}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorManufacturer
                defaultValue={monitor.monitorManufacturer}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorModel
                defaultValue={monitor.monitorModel}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorFirmwareVersion
                defaultValue={monitor.monitorFirmwareVersion}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorPurchaseDate
                defaultValue={
                  monitor.monitorPurchaseDate
                    ? new Date(monitor.monitorPurchaseDate)
                    : null
                }
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorLastServiceDate
                defaultValue={
                  monitor.monitorLastServiceDate
                    ? new Date(monitor.monitorLastServiceDate)
                    : null
                }
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <DateEnd required={true} />
            </div>

            <div className="col-md-12">
              <MonitorParameters
                required={false}
                defaultValue={monitor.monitorParameters}
                onChange={(ev) => {
                  this.updateMonitorParams(ev.target.value);
                }}
                disabled={true}
              />
            </div>

            <div className="col-md-12">
              {monitor.monitorParameters.map((param, paramIndex) => (
                <fieldset key={paramIndex} data-monitor-params>
                  <Row className="row">
                    <RowHeader>
                      <RowHeading>
                        {param.parameterName}
                        &nbsp;&nbsp;(Parameter Code {param.parameterCode})
                      </RowHeading>
                    </RowHeader>

                    <RowContent>
                      <div className="col-md-4">
                        <ParameterMeasurementTechnique
                          defaultValue={param.parameterMeasurementTechnique}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterMeasurementUnits
                          defaultValue={param.parameterMeasurementUnits}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterSamplingDuration
                          defaultValue={param.parameterSamplingDuration}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterSamplingFrequency
                          defaultValue={param.parameterSamplingFrequency}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterDetectionRangeUnits
                          defaultValue={param.parameterDetectionRangeUnits}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterUpperDetectionLimit
                          defaultValue={param.parameterUpperDetectionLimit}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterLowerDetectionLimit
                          defaultValue={param.parameterLowerDetectionLimit}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterMethodDetectionLimit
                          defaultValue={param.parameterMethodDetectionLimit}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterUncertainty
                          defaultValue={param.parameterUncertainty}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterPrecision
                          defaultValue={param.parameterPrecision}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterMeasurementResolution
                          defaultValue={param.parameterMeasurementResolution}
                          required={false}
                          disabled={true}
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterLastCalibrationTimestamp
                          defaultValue={
                            param.parameterLastCalibrationTimestamp
                              ? new Date(
                                  param.parameterLastCalibrationTimestamp,
                                )
                              : null
                          }
                          required={false}
                          disabled={true}
                        />
                      </div>
                    </RowContent>
                  </Row>
                </fieldset>
              ))}
            </div>

            <div className="col-sm-12">
              <Heading3>Monitor Setup</Heading3>
            </div>

            <div className="col-md-6">
              <MonitorCfrSiting
                defaultValue={monitor.monitorCfrCiting}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-6">
              <MonitorFlowRate
                defaultValue={monitor.monitorFlowRate}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorInletHeight
                defaultValue={monitor.monitorInletHeight}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorInletOrientation
                defaultValue={monitor.monitorInletOrientation}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-md-4">
              <MonitorInletDiameter
                defaultValue={monitor.monitorInletDiameter}
                required={false}
                disabled={true}
              />
            </div>

            <div className="col-sm-12">
              <MonitorSystemDescription
                defaultValue={monitor.monitorSystemDescription}
                required={false}
                disabled={true}
              />
            </div>
          </div>

          <div className="row">
            <div className="col-sm-12">
              <Explanation required={true} />
            </div>
          </div>

          <div className="row">
            <div className="col-md-12 text-center">
              <FormButton primary onClick={this.validateFields}>
                Deactivate Monitor
              </FormButton>
            </div>
          </div>
        </Form>
      </div>
    );
  }
}

export default UpdateMonitorForm;
