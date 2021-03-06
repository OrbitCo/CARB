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
  DateStart,
  MonitorCfrSiting,
  MonitorFlowRate,
  MonitorInletHeight,
  MonitorInletOrientation,
  MonitorInletDiameter,
  MonitorSystemDescription,
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
  onFieldsSubmit: (any) => void,
};

type State = {
  monitor: Object,
};

class UpdateMonitorForm extends React.Component<Props, State> {
  state: State = {
    monitor: { monitorParameters: [] },
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
      _transactionType: 'AM',
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

  render() {
    const { site } = this.props;
    const { monitor } = this.state;

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
              <MonitorId required={true} />
            </div>

            <div className="col-md-6">
              <MonitorPurpose required={true} />
            </div>

            <div className="col-md-4">
              <MonitorManufacturer required={true} />
            </div>

            <div className="col-md-4">
              <MonitorModel required={true} />
            </div>

            <div className="col-md-4">
              <MonitorFirmwareVersion required={true} />
            </div>

            <div className="col-md-4">
              <MonitorPurchaseDate required={true} />
            </div>

            <div className="col-md-4">
              <MonitorLastServiceDate required={true} />
            </div>

            <div className="col-md-4">
              <DateStart required={true} />
            </div>

            <div className="col-md-12">
              <MonitorParameters
                required={true}
                onChange={(ev) => {
                  this.updateMonitorParams(ev.target.value);
                }}
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
                        <ParameterMeasurementTechnique required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterMeasurementUnits required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterSamplingDuration required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterSamplingFrequency required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterDetectionRangeUnits
                          required={false} // TODO: make required if any of the other detection limit fields are filled (upper, lower, method)
                        />
                      </div>

                      <div className="col-md-4">
                        <ParameterUpperDetectionLimit required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterLowerDetectionLimit required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterMethodDetectionLimit required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterUncertainty required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterPrecision required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterMeasurementResolution required={false} />
                      </div>

                      <div className="col-md-4">
                        <ParameterLastCalibrationTimestamp required={true} />
                      </div>

                      <div className="col-md-4" />

                      <div className="col-md-4">
                        <DateStart required={true} />
                      </div>

                      <div className="col-md-4" />
                    </RowContent>
                  </Row>
                </fieldset>
              ))}
            </div>

            <div className="col-sm-12">
              <Heading3>Monitor Setup</Heading3>
            </div>

            <div className="col-md-6">
              <MonitorCfrSiting required={true} />
            </div>

            <div className="col-md-6">
              <MonitorFlowRate required={false} />
            </div>

            <div className="col-md-4">
              <MonitorInletHeight required={false} />
            </div>

            <div className="col-md-4">
              <MonitorInletOrientation required={false} />
            </div>

            <div className="col-md-4">
              <MonitorInletDiameter required={false} />
            </div>

            <div className="col-sm-12">
              <MonitorSystemDescription required={false} />
            </div>
          </div>

          <div className="row">
            <div className="col-md-12 text-center">
              <FormButton primary onClick={this.validateFields}>
                Add Monitor
              </FormButton>
            </div>
          </div>
        </Form>
      </div>
    );
  }
}

export default UpdateMonitorForm;
