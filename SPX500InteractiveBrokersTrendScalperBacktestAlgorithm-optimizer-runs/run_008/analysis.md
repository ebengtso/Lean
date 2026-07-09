# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_008/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_008/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 100
- Entry signals: 100
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8298
- Total paired trade PnL: 6567.30
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 21.5 minutes

## Lean Runtime Statistics
- Equity: $106,567.30
- Net Profit: $6,567.30
- Return: 6.57 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $42,620,804.30

## Risk And Efficiency
- Exposure hours: 35.8
- PnL per exposure hour: 183.43
- Calendar span days: 12.3
- PnL per calendar day: 533.17
- Trades per calendar day: 8.12
- Exposure share of calendar time: 12.1%
- Growth quality score: 10494.1
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 61
- Fast PnL per exposure hour: 732.16

## Pullback Broken Structure Veto
- Blocked signal rows: 1226
- Blocked by profile: `{"charm_pin_pullback_long": 1174, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 13, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 3, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 763.7999999999729, "breakout_long_no_0dte": 277.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1237.7000000001144, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2400.000000000193, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 720.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=27.8504, sortinoRatio=0, alpha=0, beta=0, informationRatio=28.4431, drawdown=0.005
- Trades: sharpeRatio=0.9728, averageMAE=-104.9140, averageMFE=84.1575, largestMAE=-603.75, largestMFE=462.60, maximumIntraTradeDrawdown=-658.00

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2400.00 | 77.42 | 100.0% | 12.0 | 9.6 | 250.87 | 0 | -403.20 | 98.00 | 3.33 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1237.70 | 36.40 | 100.0% | 5.3 | 7.5 | 164.67 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 13 | 763.80 | 58.75 | 100.0% | 15.0 | 7.4 | 103.78 | 0 | -603.75 | 76.50 | 3.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 720.00 | 72.00 | 100.0% | 15.7 | 3.9 | 186.91 | 0 | -208.25 | 77.78 | 33.59 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 70.00 | 35.00 | 100.0% | 52.6 | 1.8 | 39.94 | 0 | -243.10 | 61.55 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.16 | 29.56 | 49.07 | 19.65 | 13.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 13 | 70.52 | 6.69 | 75.11 | 28.46 | 34.0 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -105.97, median -73.10, worst -603.75
- MFE: average 84.16, median 57.80, best 462.60
- Average MFE / absolute MAE: 0.79

## Intratrade Path
- Trades with path stats: 100; with intratrade price samples: 100
- Went positive before max adverse: 52.0%
- MFE happened before MAE: 9.0%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.9 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -1.97 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-01T22:36:15+00:00` -> `2026-07-02T00:55:01+00:00`.
- Strategy/profile: `breakout_long_1dte` / `breakout_long_1dte`. PnL 35.00, MAE -603.75, MFE 54.25, hold 138.8 minutes.
- Profile context: `breakout_long_1dte` produced 13 trades, PnL 763.80, 0 slow >=12h trades, and 11.6% of total PnL.
- Entry state: setup=66.07, ES-VWAP=2.44, VWAP slope=0.1173, VWAP acceleration=0.1677, RSI=70.38, ADX=23.72, structure score=4.00, higher-low=0.0000, higher-high=2.75, pullback-from-high=1.00, rolling-high distance=1.00.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: ES structure higher-low 0.00 < 0.25; RSI 70.38 >= 70.00.
- Strategy selection reason: 0DTE expired after 16:00:00; 1DTE breakout context: 1DTE gamma/charm wall breakout acceptedWall=7550.00, gammaWall=7520.00, charmWall=7550.00, underlying=7539.75, callPut=0.7141, forwardDexRatio30m=0.2710, orderBookBullish=True, wallHL=Unknown, atm1DTE=7540.00, target1=7550.00, gammaWall1DTE=7520.00, charmWall1DTE=7550.00, forwardDEX30m1DTE=4307602083.
- Intratrade path: path MFE 1.55, path MAE -16.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 66.1` would block this trade, keep 43 trades, retain 41.9% PnL, and leave worst MAE -375.70. It would block 57 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 66.07.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all | No useful single-threshold candidate found |  |  |  |  |  |  |  |  |  |  |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `es_structure_rising_vwap != "False"` | 19 | 7 | 12 | 81 | 5195.10 | 1372.20 | 79.1% | -527.00 | 13736.7 |
| `long_strategy != "breakout_long_1dte"` | 19 | 5 | 8 | 87 | 5803.50 | 763.80 | 88.4% | -527.00 | 13735.2 |
| `strategy_profile != "breakout_long_1dte"` | 19 | 5 | 8 | 87 | 5803.50 | 763.80 | 88.4% | -527.00 | 13735.2 |
| `path_half_tp_touch_minutes >= 0.183333` | 19 | 10 | 22 | 68 | 4929.90 | 1637.40 | 75.1% | -603.75 | 409.1 |
| `option_strike_map_target_1_strike >= 7475` | 19 | 6 | 6 | 88 | 5807.40 | 759.90 | 88.4% | -603.75 | 296.3 |
| `option_strike_map_atm_straddle_points <= 66.65` | 19 | 6 | 15 | 79 | 5544.10 | 1023.20 | 84.4% | -603.75 | 235.4 |
| `option_strike_map_target_1_strike >= 7500` | 19 | 7 | 22 | 71 | 5190.30 | 1377.00 | 79.0% | -603.75 | 234.9 |
| `option_strike_map_underlying_price >= 7443.25` | 19 | 5 | 6 | 89 | 5848.20 | 719.10 | 89.1% | -603.75 | 230.0 |
| `option_strike_map_atm_strike >= 7445` | 19 | 5 | 6 | 89 | 5848.20 | 719.10 | 89.1% | -603.75 | 230.0 |
| `option_strike_map_target_2_strike >= 7511.93` | 19 | 5 | 6 | 89 | 5848.20 | 719.10 | 89.1% | -603.75 | 230.0 |
| `option_strike_map_atm_straddle_points <= 63.15` | 19 | 8 | 27 | 65 | 4739.70 | 1827.60 | 72.2% | -603.75 | 220.0 |
| `es_last >= 7465` | 19 | 5 | 8 | 87 | 5715.60 | 851.70 | 87.0% | -603.75 | 203.1 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 35981
- position_wait: 8298
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 479
- order_event: 453
- waiting_spx_quote: 415
- entry_signal: 100

## Blocked Gate Counts
- setup_quality_allowed: 14331 (disabled=14331)
- above_vwap_confirmed: 9101 (disabled=9101)
- above_vwap: 8097 (disabled=8097)
- es_structure_allowed: 7815 (disabled=7815)
- pullback: 6575 (disabled=6575)
- momentum: 4172 (disabled=4172)
- es_vwap_max_distance_allowed: 3828 (disabled=3828)
- es_vwap_slope_allowed: 3673 (disabled=3673)
- trend_strength: 3333 (disabled=3333)
- es_vwap_acceleration_allowed: 1899 (disabled=1899)
- es_rolling_high_allowed: 496 (disabled=496)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1300.40 | 118.22 | 100.0% | 16.6 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 323.80 | 53.97 | 100.0% | 14.0 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 243.80 | 48.76 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 1 | 4 | 295.20 | 73.80 | 100.0% | 7.3 |
| 22 | 4 | 389.80 | 97.45 | 100.0% | 14.9 |
| 7 | 4 | 240.70 | 60.17 | 100.0% | 12.0 |
| 0 | 2 | 139.40 | 69.70 | 100.0% | 7.3 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |
| 2 | 1 | 36.00 | 36.00 | 100.0% | 133.4 |
| 3 | 1 | 40.80 | 40.80 | 100.0% | 29.4 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 55 | 3311.60 | 60.21 | 100.0% | 7.1 |
| 55-60 | 15 | 1192.50 | 79.50 | 100.0% | 15.3 |
| 70-75 | 10 | 482.00 | 48.20 | 100.0% | 23.5 |
| >=75 | 9 | 789.40 | 87.71 | 100.0% | 12.1 |
| 60-65 | 7 | 284.80 | 40.69 | 100.0% | 29.4 |
| 65-70 | 4 | 507.00 | 126.75 | 100.0% | 14.2 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 40 | 2681.40 | 67.04 | 100.0% | 8.6 |
| 20-25 | 21 | 1569.70 | 74.75 | 100.0% | 12.7 |
| 30-40 | 17 | 1087.80 | 63.99 | 100.0% | 12.0 |
| 25-30 | 16 | 887.00 | 55.44 | 100.0% | 13.4 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 100 | 6567.30 | 65.67 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 96 | 5988.90 | 62.38 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 561.40 | 187.13 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 45 | 2784.70 | 61.88 | 100.0% | 12.1 |
| -0.05-0 | 36 | 2323.30 | 64.54 | 100.0% | 7.8 |
| 0.1-0.25 | 10 | 1032.60 | 103.26 | 100.0% | 15.7 |
| 0.05-0.1 | 6 | 286.20 | 47.70 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 30 | 1514.50 | 50.48 | 100.0% | 6.4 |
| 2-4 | 21 | 1109.00 | 52.81 | 100.0% | 15.3 |
| 0-1 | 15 | 1237.40 | 82.49 | 100.0% | 14.7 |
| 6-8 | 14 | 1432.20 | 102.30 | 100.0% | 10.8 |
| 8-12 | 8 | 397.00 | 49.62 | 100.0% | 13.0 |
| 1-2 | 6 | 396.90 | 66.15 | 100.0% | 22.0 |
| 12-20 | 5 | 445.30 | 89.06 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 32 | 2309.80 | 72.18 | 100.0% | 8.0 |
| <1 | 21 | 1495.10 | 71.20 | 100.0% | 16.0 |
| 1-3 | 12 | 908.10 | 75.68 | 100.0% | 14.7 |
| 10-20 | 12 | 645.80 | 53.82 | 100.0% | 12.3 |
| 5-10 | 12 | 640.50 | 53.38 | 100.0% | 10.3 |
| 3-5 | 10 | 501.50 | 50.15 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 31 | 2329.60 | 75.15 | 100.0% | 12.7 |
| 0-1 | 18 | 876.60 | 48.70 | 100.0% | 6.0 |
| <-3 | 9 | 418.70 | 46.52 | 100.0% | 6.7 |
| -1-0 | 8 | 501.50 | 62.69 | 100.0% | 14.1 |
| -2--1 | 8 | 524.40 | 65.55 | 100.0% | 16.6 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 6 | 448.70 | 74.78 | 100.0% | 13.5 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 52.9 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| -1-0 | 35 | 2566.10 | 73.32 | 100.0% | 14.0 |
| 0-1 | 35 | 2301.80 | 65.77 | 100.0% | 12.0 |
| 1-2 | 17 | 1011.60 | 59.51 | 100.0% | 8.4 |
| -2--1 | 7 | 246.40 | 35.20 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 31 | 1643.30 | 53.01 | 100.0% | 12.7 |
| 1-2 | 20 | 1131.70 | 56.59 | 100.0% | 7.8 |
| 4-8 | 16 | 1795.80 | 112.24 | 100.0% | 12.1 |
| >=8 | 16 | 1110.00 | 69.38 | 100.0% | 15.3 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 40 | 2471.90 | 61.80 | 100.0% | 12.6 |
| 3 | 33 | 2597.30 | 78.71 | 100.0% | 12.0 |
| 5 | 26 | 1464.10 | 56.31 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 40 | 3138.70 | 78.47 | 100.0% | 13.6 |
| 2-4 | 29 | 1623.70 | 55.99 | 100.0% | 11.9 |
| 4-8 | 26 | 1581.40 | 60.82 | 100.0% | 8.5 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2730.70 | 71.86 | 100.0% | 12.0 |
| 2-4 | 14 | 530.30 | 37.88 | 100.0% | 14.1 |
| 0-0.5 | 10 | 649.20 | 64.92 | 100.0% | 14.2 |
| 1-2 | 10 | 747.20 | 74.72 | 100.0% | 12.6 |
| 4-8 | 10 | 455.60 | 45.56 | 100.0% | 8.4 |
| 0.5-1 | 9 | 737.80 | 81.98 | 100.0% | 5.8 |
| >=8 | 9 | 716.50 | 79.61 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 37 | 2654.70 | 71.75 | 100.0% | 8.5 |
| 2-4 | 19 | 1263.80 | 66.52 | 100.0% | 11.9 |
| 4-8 | 15 | 1021.70 | 68.11 | 100.0% | 12.1 |
| 1-2 | 10 | 573.40 | 57.34 | 100.0% | 17.8 |
| >=8 | 9 | 558.00 | 62.00 | 100.0% | 14.7 |
| 0-0.5 | 6 | 243.80 | 40.63 | 100.0% | 19.0 |
| 0.5-1 | 4 | 251.90 | 62.98 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 34 | 2381.60 | 70.05 | 100.0% | 13.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 14 | 1492.20 | 106.59 | 100.0% | 23.5 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 2-4 | 5 | 332.60 | 66.52 | 100.0% | 12.0 |
| 0-2 | 4 | 223.60 | 55.90 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 30 | 2108.90 | 70.30 | 100.0% | 7.5 |
| 60-70 | 25 | 1307.10 | 52.28 | 100.0% | 12.1 |
| 70-80 | 19 | 1434.80 | 75.52 | 100.0% | 12.0 |
| 40-50 | 15 | 1168.60 | 77.91 | 100.0% | 11.9 |
| 80-90 | 11 | 547.90 | 49.81 | 100.0% | 16.6 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 24 | 1463.30 | 60.97 | 100.0% | 11.9 |
| 2-3 | 22 | 958.40 | 43.56 | 100.0% | 15.8 |
| 1-2 | 20 | 1393.50 | 69.68 | 100.0% | 12.6 |
| 4-5 | 15 | 1505.00 | 100.33 | 100.0% | 9.4 |
| 5-6 | 13 | 755.00 | 58.08 | 100.0% | 7.2 |
| <1 | 6 | 492.10 | 82.02 | 100.0% | 20.7 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 100 | 6567.30 | 65.67 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 100 | 6567.30 | 65.67 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 34 | 2381.60 | 70.05 | 100.0% | 13.9 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 14 | 1492.20 | 106.59 | 100.0% | 23.5 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 2-4 | 5 | 332.60 | 66.52 | 100.0% | 12.0 |
| 0-2 | 4 | 223.60 | 55.90 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 69 | 4149.50 | 60.14 | 100.0% | 8.7 |
| 2-4 | 10 | 865.90 | 86.59 | 100.0% | 28.1 |
| 4-6 | 6 | 440.00 | 73.33 | 100.0% | 8.9 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 229.80 | 45.96 | 100.0% | 16.6 |
| 1-2 | 2 | 71.00 | 35.50 | 100.0% | 82.8 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3332.70 | 90.07 | 100.0% | 11.9 |
| 15-30 | 25 | 779.00 | 31.16 | 100.0% | 19.1 |
| <5 | 24 | 1555.10 | 64.80 | 100.0% | 1.0 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 112.5 |
| 30-60 | 6 | 186.50 | 31.08 | 100.0% | 35.9 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 100 | 6567.30 | 65.67 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5434.30 | 67.09 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 13 | 763.80 | 58.75 | 100.0% | 15.0 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5434.30 | 67.09 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 13 | 763.80 | 58.75 | 100.0% | 15.0 |
| STALE_0DTE | 5 | 161.80 | 32.36 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 63 | 3907.10 | 62.02 | 11.9 | 14.3 | 273.28 | 0 |
| 2026-07 | 37 | 2660.20 | 71.90 | 15.6 | 21.5 | 123.70 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1237.70 | 36.40 | 5.3 |
| 2.49 | 1 | 44.20 | 44.20 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 13 | 763.80 | 58.75 | 15.0 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.26 | 1 | 115.50 | 115.50 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | 36.00 | 36.00 | 155.4 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 6 | 538.10 | 89.68 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 277.40 | 92.47 | 23.3 |
| 12.00 | 5 | 985.60 | 197.12 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 70.00 | 35.00 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
